using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MoveController))]
public class Player : MonoBehaviour {
    [System.Serializable]
    public class MouseInput {
        public Vector2 damping;
        public Vector2 sensitivity;
    }

    [SerializeField] float speed;
    [SerializeField] MouseInput mouseControl;

    private MoveController m_moveController;
    public MoveController moveController {
        get {
            if(m_moveController == null) {
                m_moveController = GetComponent<MoveController>();
            }
            return m_moveController;
        }
    }

    InputController playerInput;
    Vector2 mouseInput;

    // Start is called before the first frame update
    void Awake() {
        playerInput = GameManager.Instance.inputController;
        GameManager.Instance.LocalPlayer = this;

    }

    // Update is called once per frame
    void Update() {
        Vector2 direction = new Vector2(playerInput.vertical * speed, playerInput.horizontal * speed);
        moveController.Move(direction);

        mouseInput.x = Mathf.Lerp(mouseInput.x, playerInput.mouseInput.x, 1f / mouseControl.damping.x);
        transform.Rotate(Vector3.up * mouseInput.x * mouseControl.sensitivity.x);
    }
}
