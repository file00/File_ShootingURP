using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMove : MonoBehaviour
{
    // 사용자의 입력을 받아서 그 입력받은 방향으로 이동하게 하고 싶다.
    // 1. 사용자의 Input을 받는다. -> 상하 좌우 입력을 받는다.
    // 2. 입력받은 방향과 속력을 설정한다. (Speed)
    // 3. 그 속도로 이동하게 하고 싶다. -> p = p0 + vt 

    public float speed = 10.0f;
    public bool isUpDown = false;

    void Start()
    {
        
    }

    void Update()
    {
        // p = p0 + vt 
        // transform.position += Vector3.left * speed * Time.deltaTime;
        // print(Time.deltaTime);

        if (isUpDown)
        {
            MoveType1();
        }
        else 
        {
            MoveType2();
        }
    }

    void MoveType1()
    {
        // 사용자의 상하 좌우 Input 값을 출력하기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // print(h);

        // 좌우 Input 값을 Vector로 만들기
        Vector3 direction = new Vector3(h, v, 0);

        // Direction Vector의 길이를 1로 Normalize하기
        direction.Normalize();

        // p = p0 + vt 공식을 이용해서 Player의 위치를 이동시키기
        transform.position += direction * speed * Time.deltaTime;
    }

    void MoveType2()
    {
        // 사용자의 상하 좌우 Input 값을 출력하기
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // print(h);

        // 좌우 Input 값을 Vector로 만들기
        Vector3 direction = new Vector3(h, 0, v);

        // Direction Vector의 길이를 1로 Normalize하기
        direction.Normalize();

        // p = p0 + vt 공식을 이용해서 Player의 위치를 이동시키기
        transform.position += direction * speed * Time.deltaTime;
    }

    // Memory에서 삭제되기 직전에 1회 호출되는 Function( = Call Back Function)
    private void OnDestroy()
    {
        
    }
}
