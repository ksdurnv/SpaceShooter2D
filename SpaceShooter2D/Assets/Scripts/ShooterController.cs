using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public float moveSpeed;
    public Animator animator;

    void Start()
    {
        moveSpeed = 3f;
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, v, 0); //¹æÇâ
        Vector3 movement = dir.normalized * this.moveSpeed * Time.deltaTime;

        this.transform.Translate(movement);

        if (h > 0)
        {
            animator.SetInteger("State", 2);
        }
        else if (h < 0)
        {
            animator.SetInteger("State", 1);
        }
        else
        {
            animator.SetInteger("State", 0);
        }
    }
}
