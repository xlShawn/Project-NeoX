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
        inputY = Input.GetAxis("Vertical");
        animator.SetFloat("InputY", -1 * Mathf.Abs(inputY));

    }
}
