using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // 처음 1회 Enemy를 자신(EnemyFactory Object)의 위치에서 생성한다.
    public GameObject enemyPrefab; 

    void Start()
    {
        GameObject go = Instantiate(enemyPrefab);
        go.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
