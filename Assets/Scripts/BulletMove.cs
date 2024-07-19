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

    void Update()
    {
        // 총알을 위로 계속 이동하게 하고싶다.
        // Vector3 dir = Vector3.up;
        Vector3 dir = new Vector3(0, 1, 0);

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // If, 충돌이 발생한다면..
    private void OnCollisionEnter(Collision collision)
    {
        // 상대방 Object를 제거한다.
        Destroy(collision.gameObject);

        // 나를 제거한다.    
        Destroy(gameObject);
    }

}
