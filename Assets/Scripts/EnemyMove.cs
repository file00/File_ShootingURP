using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 1. ����ؼ� �Ʒ��� �������� �ϰ� �ʹ�.
    // Speed, Direction
    public float moveSpeed = 6;

    // 2. Player�� �ִ� �������� �̵��ϰ� �ʹ�.
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        // Player�� �ִ� Direction�� ����Ѵ�.
        // dir = target.transform.position - transform.position;
        // dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        
        // ���� �������� �̵��Ѵ�.
        // transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
