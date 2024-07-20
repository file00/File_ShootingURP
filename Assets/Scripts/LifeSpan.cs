using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    // 지정된 시간이 되면, 나를 제거한다(Life).
    // 필요한 것: 지정된 시간, 경과된 시간
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
