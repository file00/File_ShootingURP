using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerMove : MonoBehaviour
{
    // 나는 계속해서 Player를 쫓아가겠다.
    // Player를 향한 Direction, Move Speed
    // 계산된 방향과 Speed 대로 이동한다.(p = p0 + vt)

    public GameObject target;
    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // 내가 Player를 바라보는 방향 Vector를 구한다.
        Vector3 dir = target.transform.position - transform.position;

        // Normaliza Vector Direction
        dir.Normalize();

        // 그 방향과 속력대로 이동한다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
