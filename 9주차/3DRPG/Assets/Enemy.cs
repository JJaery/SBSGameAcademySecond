using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //1. 상태에 대한 정의들
    public enum eState
    {
        Invalid, /// 초기화 안된 상태(스크립트에서 설정이 덜 된 상태)
        Idle,/// 대기 상태 == 패트롤 [적(플레이어)을 찾아 떠나는 행위]
        Trace, /// 적을 발견하고 쫓아가는 상태
        Attack, /// 적이 사정거리 안에 들어와서 공격중인 상태
        Dead, /// 죽어 있는 상태
    }

    private eState curState = eState.Invalid;


    private void Start()
    {
        ChangeState(eState.Idle);
    }

    private void ChangeState(eState targetState)
    {
        if (curState == targetState)
            return;

        ///State가 끝날 때 메소드 호출
        switch(curState)
        {
            case eState.Invalid:
                break;
            case eState.Idle:
                OnExitIdleState();
                break;
            case eState.Trace:
                OnExitTraceState();
                break;
            case eState.Attack:
                OnExitAttackState();
                break;
            case eState.Dead:
                break;
        }

        curState = targetState;
        ///State가 전환되고 나서 메소드 호출
        switch (curState)
        {
            case eState.Invalid:
                break;
            case eState.Idle:
                OnEnterIdleState();
                break;
            case eState.Trace:
                OnEnterTraceState();
                break;
            case eState.Attack:
                OnEnterAttackState();
                break;
            case eState.Dead:
                OnEnterDeadState();
                break;
        }
    }

    private void Update()
    {
        switch (curState)
        {
            case eState.Invalid:
                break;
            case eState.Idle:
                OnUpdateIdleState();
                break;
            case eState.Trace:
                OnUpdateTraceState();
                break;
            case eState.Attack:
                OnUpdateAttackState();
                break;
            case eState.Dead:
                OnUpdateDeadState();
                break;
        }
    }

    private void OnUpdateIdleState()
    {

    }
    private void OnUpdateTraceState()
    {

    }
    private void OnUpdateAttackState()
    {

    }
    private void OnUpdateDeadState()
    {

    }

    /// <summary>
    /// Idle 상태 진입점
    /// </summary>
    private void OnEnterIdleState()
    {
        MoveRandomPosition();
    }

    private void MoveRandomPosition()
    {     
        ///내 주변에 임의의 좌표를 구한다.
        float randomX = Random.Range(-5, 5) + transform.position.x;
        float randomZ = Random.Range(-5, 5) + transform.position.z;

        Vector3 targetPosition = new Vector3(randomX, transform.position.y, randomZ);

        StopCoroutine("MovePosition");
        StartCoroutine(MovePosition(targetPosition));
    }

    IEnumerator MovePosition(Vector3 targetPosition)
    {
        float distance = Vector3.Distance(transform.position, targetPosition);

        while(distance >= 0.05f)
        {
            transform.position += (targetPosition - transform.position).normalized * 10f * Time.deltaTime;
            yield return null;
            distance = Vector3.Distance(transform.position, targetPosition);
        }

        MoveRandomPosition();
    }

    private void OnEnterTraceState()
    {
    }
    private void OnEnterAttackState()
    {

    }
    private void OnEnterDeadState()
    {

    }


    private void OnExitIdleState()
    {
    }
    private void OnExitTraceState()
    {

    }
    private void OnExitAttackState()
    {

    }
}
