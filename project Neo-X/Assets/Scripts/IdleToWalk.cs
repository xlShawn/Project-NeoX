using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToWalk : MonoBehaviour
{
    public Animator animator;
    float inputX;
    public float inputY;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        inputY = Mathf.Max(Mathf.Abs(Input.GetAxis("Vertical")), Mathf.Abs(Input.GetAxis("Horizontal")));
        animator.SetFloat("inputX", -1 * Mathf.Abs(inputY));
    }
}
