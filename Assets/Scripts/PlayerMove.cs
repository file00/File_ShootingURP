using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerMove : MonoBehaviour
{
    // ������� �Է��� �޾Ƽ� �� �Է¹��� �������� �̵��ϰ� �ϰ� �ʹ�.
    // 1. ������� Input�� �޴´�. -> ���� �¿� �Է��� �޴´�.
    // 2. �Է¹��� ����� �ӷ��� �����Ѵ�. (Speed)
    // 3. �� �ӵ��� �̵��ϰ� �ϰ� �ʹ�. -> p = p0 + vt 

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
        // ������� ���� �¿� Input ���� ����ϱ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // print(h);

        // �¿� Input ���� Vector�� �����
        Vector3 direction = new Vector3(h, v, 0);

        // Direction Vector�� ���̸� 1�� Normalize�ϱ�
        direction.Normalize();

        // p = p0 + vt ������ �̿��ؼ� Player�� ��ġ�� �̵���Ű��
        transform.position += direction * speed * Time.deltaTime;
    }

    void MoveType2()
    {
        // ������� ���� �¿� Input ���� ����ϱ�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // print(h);

        // �¿� Input ���� Vector�� �����
        Vector3 direction = new Vector3(h, 0, v);

        // Direction Vector�� ���̸� 1�� Normalize�ϱ�
        direction.Normalize();

        // p = p0 + vt ������ �̿��ؼ� Player�� ��ġ�� �̵���Ű��
        transform.position += direction * speed * Time.deltaTime;
    }

    // Memory���� �����Ǳ� ������ 1ȸ ȣ��Ǵ� Function( = Call Back Function)
    private void OnDestroy()
    {
        
    }
}
