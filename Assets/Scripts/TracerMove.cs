using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerMove : MonoBehaviour
{
    // ���� ����ؼ� Player�� �Ѿư��ڴ�.
    // Player�� ���� Direction, Move Speed
    // ���� ����� Speed ��� �̵��Ѵ�.(p = p0 + vt)

    public GameObject target;
    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // ���� Player�� �ٶ󺸴� ���� Vector�� ���Ѵ�.
        Vector3 dir = target.transform.position - transform.position;

        // Normaliza Vector Direction
        dir.Normalize();

        // �� ����� �ӷ´�� �̵��Ѵ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
