using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    // ������ �ð��� �Ǹ�, ���� �����Ѵ�(Life).
    // �ʿ��� ��: ������ �ð�, ����� �ð�
    public float m_lifespan = 3.0f;

    float currentTime = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > m_lifespan)
        {
            Destroy(gameObject);
        }
    }
}
