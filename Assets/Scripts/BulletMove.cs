using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // �Ѿ��� ���� ��� �̵��ϰ� �ϰ� �ʹ�.
    // Direction = Up, Size = Move Speed
    public float moveSpeed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        // �Ѿ��� ���� ��� �̵��ϰ� �ϰ�ʹ�.
        // Vector3 dir = Vector3.up;
        Vector3 dir = new Vector3(0, 1, 0);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // If, �浹�� �߻��Ѵٸ�..
    private void OnCollisionEnter(Collision collision)
    {
        // ���� Object�� �����Ѵ�.
        Destroy(collision.gameObject);

        // ���� �����Ѵ�.    
        Destroy(gameObject);
    }

}
