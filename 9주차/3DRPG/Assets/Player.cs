using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;

    [Range(1,100)]
    public float MoveSpeed;

    private float atkFreezeTime = .8f;
    private bool isMovable = true;

    void Update()
    {
        Attack();
        Move();
    }

    private void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Attack");
            isMovable = false;
            StopCoroutine("DelayMethod");
            StartCoroutine(DelayMethod(atkFreezeTime));
        }
    }
    IEnumerator DelayMethod(float time)
    {
        yield return new WaitForSeconds(time);
        isMovable = true;
    }
    private void Move()
    {
        if (isMovable == false)
        {
            animator.SetBool("isBack", false);
            animator.SetBool("isRun", false);
            return;
        }

        Vector3 dir = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            dir += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            dir += transform.right * -1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            dir += transform.forward * -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            dir += transform.right;
        }

        if (dir == transform.forward * -1) /// 뒤로가기 일 경우
        {
            animator.SetBool("isBack", true);
        }
        else
        {
            animator.SetBool("isBack", false);
            animator.SetBool("isRun", dir != Vector3.zero);
        }

        transform.position += dir.normalized * Time.deltaTime * MoveSpeed;
    }
}
