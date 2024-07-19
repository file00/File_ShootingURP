using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    // 물리적 충돌이 일어났을 때 1회 실행되는 Callback(Event) Function
    private void OnCollisionEnter(Collision collision)
    {
        // print(collision.gameObject.name);
        print("Start Crash!!");
    }

    // 충돌이 발생 중인 내내 실행되는 Callback Function
    private void OnCollisionStay(Collision collision)
    {
        print("Crashing!!");
    }

    // 충돌이 종료될 때 1회 실행되는 Callback Function
    private void OnCollisionExit(Collision collision)
    {
        print("Exit");
    }

    // 충돌 감지가 일어났을 때 1회 실행되는 Callback(Event) Function
    private void OnTriggerEnter(Collider other)
    {
        print("영역에 들어왔다.");
    }

    // 충돌 감지가 진행 중인 내내 실행되는 Callback Function
    private void OnTriggerStay(Collider other)
    {
        print("영역 내에 아직 있다.");
    }

    // 충돌 감지가 종료될 때 1회 실행되는 Callback Function
    private void OnTriggerExit(Collider other)
    {
        print("영역에서 빠져 나왔다.");
    }
}
