using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player : LivingEntity /* Health system*/ {

    public static bool weaponEquipment = false;
    //Animator anim; Tui left this here
    //anim = getcomponent<Animator>(); Tui left this here
    PlayerController controller;
    GunController gunController;
    //Shawn Player script ^


    [System.Serializable]
    public class MouseInput {
        public Vector2 damping;
        public Vector2 sensitivity;
    }

    [SerializeField] float speed;
    [SerializeField] MouseInput mouseControl;
    public PlayerAim playerAim;

    private MoveController m_moveController;

    public MoveController moveController {
        get {
            if (m_moveController == null) {
                m_moveController = GetComponent<MoveController>();
                //Anim.play("Run"); Tui left this here
            }
            return m_moveController;
        }
    }

    private Crosshair m_crosshair;
    private Crosshair Crosshair {
        get {
            if (m_crosshair == null) {
                m_crosshair = GetComponentInChildren<Crosshair>();
            }
            return m_crosshair;
        }
    }

    InputController playerInput;
    Vector2 mouseInput;

    protected override void Start()
    {
        base.Start();
        controller = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();

    }

    // Start is called before the first frame update
    void Awake() {
        playerInput = GameManager.Instance.inputController;
        GameManager.Instance.LocalPlayer = this;

    }

    // Update is called once per frame
    void Update() {
        Vector2 direction = new Vector2(playerInput.vertical * speed, playerInput.horizontal * speed*0.6f);
        moveController.Move(direction);

        mouseInput.x = Mathf.Lerp(mouseInput.x, playerInput.mouseInput.x, 1f / mouseControl.damping.x);
        mouseInput.y = Mathf.Lerp(mouseInput.y, playerInput.mouseInput.y, 1f / mouseControl.damping.y);

        transform.Rotate(Vector3.up * mouseInput.x * mouseControl.sensitivity.x);

        Crosshair.LookHeight(mouseInput.y * mouseControl.sensitivity.y);
        playerAim.setRotation(mouseInput.y * mouseControl.sensitivity.y);



        //Weapon Input --Shawn Script
        if (weaponEquipment == true)
        {
            if (Input.GetMouseButton(0))
            {
                gunController.Shoot();
            }
        }

    }
}
