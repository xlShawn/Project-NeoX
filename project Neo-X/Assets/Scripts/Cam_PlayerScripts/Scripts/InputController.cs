using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    public Vector2 mouseInput;
    public Animator animator;
    float inputX;
    float inputY;
    public bool Fire1;

    void Start() {
        animator = this.gameObject.GetComponent<Animator>();

    }

    void Update() {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        Fire1 = Input.GetButton("Fire1");
    }

}
