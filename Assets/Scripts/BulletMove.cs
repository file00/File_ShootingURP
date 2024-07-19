using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // 총알을 위로 계속 이동하게 하고 싶다.
    // Direction = Up, Size = Move Speed
    public float moveSpeed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 총알을 위로 계속 이동하게 하고싶다.
        // Vector3 dir = Vector3.up;
        Vector3 dir = new Vector3(0, 1, 0);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
