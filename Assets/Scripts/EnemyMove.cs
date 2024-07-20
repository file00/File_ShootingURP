using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // ������ Ȯ���� ���� �̵� ����� �ٸ��� �ϰ� �ʹ�.
    // �ʿ� ���: Random ����, Ȯ�� ����
    // public int traceRate = 30;
    public float traceRate = 0.3f;

    // 1. ����ؼ� �Ʒ��� �������� �ϰ� �ʹ�.
    // Speed, Direction
    public float moveSpeed = 6;

    // 2. Player�� �ִ� �������� �̵��ϰ� �ʹ�.
    public GameObject target;

    Vector3 dir;

    void Start()
    {
        // Scene�� �ִ� GameObject �� Player��� �̸��� Object�� ã�´�.
        // ã�� Object�� �ִٸ�, �� Object�� Target ������ �ִ´�.
        target = GameObject.Find("Player");

        // If, Target ������ ���� null�̶��??
        if(target == null)
        {
            // dir ������ ������ �Ʒ��� �����Ѵ�.
            dir = Vector3.down;

            // Start Function�� ������.
            return;
        }

        // 1. 1 ~ 100 ���� Random�� ���� ������ Random�ϰ� �����ϳ��� ��÷�Ѵ�.
        // ������ ����(Deprecate): �� ����� ����
        // int number = Random.Range(1, 101);
        float number = Random.Range(0.0f, 1.0f);

        // 2. If, ��÷�� ���ڰ� Ȯ�� ���� �� ���϶��..
        if (number <= traceRate)
        {
            // 2-1. Player�� �ִ� �������� dir ������ �����Ѵ�.
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
        // 3. Else..
        else
        {
            // 3-1. dir ������ ���� �Ʒ� �������� �����Ѵ�.
            dir = new Vector3(0, -1, 0);
        }
    }

    void Update()
    {
        // transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        
        // ���� �������� �̵��Ѵ�.
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
