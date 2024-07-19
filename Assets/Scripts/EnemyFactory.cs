using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    // ������ �ð����� Enemy�� �ڽ�(EnemyFactory Object)�� ��ġ���� �����Ѵ�.
    // ������ �ð�, ���� ����� �ð�
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;

    public float generateTime = 2.0f;

    float currentTime = 0;

    void Start()
    {
     
    }

    void Update()
    {
        // ���� Frame���� ���� Frame���� ����� Time�� ������Ų��(Total Time).    
        currentTime += Time.deltaTime;

        // If, ������ Time�� ������ Time�� �����ߴٸ�... 
        if (currentTime > generateTime)
        {
            // Enemy�� �ڽ��� ��ġ���� �����Ѵ�.

            // 30[%]Ȯ���� 1�� Prefab, 20[%] Ȯ���� 2�� Prefab, 50[%] Ȯ���� 3�� Prefab�� �����ǰ� �ϰ� �ʹ�.
            float num = Random.Range(0.0f, 1.0f);
            GameObject selectedObject = enemyPrefab1;
            if (num <= 1.0f)
            {
                selectedObject = enemyPrefab1;
            }
            //else if (num < 0.5f)
            //{
            //    selectedObject = enemyPrefab2;
            //}
            //else
            //{
            //    selectedObject = enemyPrefab3;
            //}

            GameObject go = Instantiate(selectedObject);
            go.transform.position = transform.position;

            // ���� �ð��� 0�ʷ� �ٽ� �ʱ�ȭ�Ѵ�.
            currentTime = 0;
        }
    }
}
