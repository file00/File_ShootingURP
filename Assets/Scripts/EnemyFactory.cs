using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ó�� 1ȸ Enemy�� �ڽ�(EnemyFactory Object)�� ��ġ���� �����Ѵ�.
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
