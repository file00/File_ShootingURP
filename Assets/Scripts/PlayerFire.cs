using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Mouse�� Left Button Click�� Bullet�� �߻�ǰ� �ϰ� �ʹ�.
    // 1. Bullet�� Prefab�� �ȴ�.
    public GameObject bulletPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        // 2. Mouse Left Button�� Input(Mouse Button ���� ���� 1ȸ)�� �޴´�.
        bool mouseInput = Input.GetButtonDown("Fire1");

        if(mouseInput)
        {
            // print("Mouse Left Button Click");

            // 3. Bullet�� ���� ��ġ�� �����Ѵ�.
            Vector3 firePosition = transform.position + new Vector3(0, 1, 0);

            // 4. Bullet Prefab�� Scene�� ����(Memory)�Ѵ�.
            GameObject bulletInstance = Instantiate(bulletPrefab);

            // 5. ������ Bullet Instance�� ��ġ�� �ռ� ������ ��ġ�� �����Ѵ�.(�Ѿ��� �ѱ� ��ġ�� ������ ���´�.)
            bulletInstance.transform.position = firePosition;
        }
    }
}
