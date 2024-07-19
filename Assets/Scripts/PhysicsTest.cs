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

    // ������ �浹�� �Ͼ�� �� 1ȸ ����Ǵ� Callback(Event) Function
    private void OnCollisionEnter(Collision collision)
    {
        // print(collision.gameObject.name);
        print("Start Crash!!");
    }

    // �浹�� �߻� ���� ���� ����Ǵ� Callback Function
    private void OnCollisionStay(Collision collision)
    {
        print("Crashing!!");
    }

    // �浹�� ����� �� 1ȸ ����Ǵ� Callback Function
    private void OnCollisionExit(Collision collision)
    {
        print("Exit");
    }

    // �浹 ������ �Ͼ�� �� 1ȸ ����Ǵ� Callback(Event) Function
    private void OnTriggerEnter(Collider other)
    {
        print("������ ���Դ�.");
    }

    // �浹 ������ ���� ���� ���� ����Ǵ� Callback Function
    private void OnTriggerStay(Collider other)
    {
        print("���� ���� ���� �ִ�.");
    }

    // �浹 ������ ����� �� 1ȸ ����Ǵ� Callback Function
    private void OnTriggerExit(Collider other)
    {
        print("�������� ���� ���Դ�.");
    }
}
