using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 1. 계속해서 아래로 내려가게 하고 싶다.
    // Speed, Direction
    public float moveSpeed = 6;

    // 2. Player가 있는 방향으로 이동하고 싶다.
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        // Player가 있는 Direction을 계산한다.
        // dir = target.transform.position - transform.position;
        // dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        
        // 계산된 방향으로 이동한다.
        // transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
