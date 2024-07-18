using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // I want to keep moving to the right.
    // 1. Direction == Right
    // 2. Determine the speed at which to travel.
    // 3. Change my actual position in a set direction and speed.
    public float speed = 10.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // p = p0 + vt 
        transform.position += Vector3.left * speed * Time.deltaTime;
        // print(Time.deltaTime);
    }
}
