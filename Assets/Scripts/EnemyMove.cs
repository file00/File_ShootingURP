using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 일정한 확률에 따라 이동 방식을 다르게 하고 싶다.
    // 필요 요소: Random 범위, 확률 변수
    // public int traceRate = 30;
    public float traceRate = 0.3f;

    // 1. 계속해서 아래로 내려가게 하고 싶다.
    // Speed, Direction
    public float moveSpeed = 6;

    // 2. Player가 있는 방향으로 이동하고 싶다.
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        // Scene에 있는 GameObject 중 Player라는 이름의 Object를 찾는다.
        // 찾은 Object가 있다면, 그 Object를 Target 변수에 넣는다.
        target = GameObject.Find("Player");

        // If, Target 변수의 값이 null이라면??
        if(target == null)
        {
            // dir 변수의 방향을 아래로 설정한다.
            dir = Vector3.down;

            // Start Function을 끝낸다.
            return;
        }

        // 1. 1 ~ 100 까지 Random한 범위 내에서 Random하게 숫자하나를 추첨한다.
        // 사용되지 않음(Deprecate): 곧 사라질 예정
        // int number = Random.Range(1, 101);
        float number = Random.Range(0.0f, 1.0f);

        // 2. If, 추첨된 숫자가 확률 변수 값 이하라면..
        if (number <= traceRate)
        {
            // 2-1. Player가 있는 방향으로 dir 변수를 설정한다.
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // 3. Else..
        else
        {
            // 3-1. dir 변수의 값을 아래 방향으로 설정한다.
            dir = new Vector3(0, -1, 0);
        }
    }

    void Update()
    {
        // transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        
        // 계산된 방향으로 이동한다.
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("DestroyZone"))
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
