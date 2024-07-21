using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Mouse�� Left Button Click�� Bullet�� �߻�ǰ� �ϰ� �ʹ�.
    // 1. Bullet�� Prefab�� �ȴ�.
    public GameObject bulletPrefab;
    public GameObject firePosition;
    public AudioClip[] sounds = new AudioClip[2];

    AudioSource firesound;

    void Start()
    {
        // 1. Audio Source Component�� �����´�.(Caching)
        firesound = gameObject.GetComponent<AudioSource>();

        // Volume 0.1�� ����
        if (firesound != null)
        {
            firesound.volume = 0.1f;
        }
    }

    void Update()
    {
        // 2. Mouse Left Button�� Input(Mouse Button ���� ���� 1ȸ)�� �޴´�.
        bool mouseInput = Input.GetButtonDown("Fire1");

        if(mouseInput)
        {
            // print("Mouse Left Button Click");

            // 3. Bullet�� ���� ��ġ�� �����Ѵ�.
            // Vector3 firePosition = transform.position + new Vector3(0, 1, 0);

            // 4. Bullet Prefab�� Scene�� ����(Memory)�Ѵ�.
            GameObject bulletInstance = Instantiate(bulletPrefab);

            // 5. ������ Bullet Instance�� ��ġ�� �ռ� ������ ��ġ�� �����Ѵ�.(�Ѿ��� �ѱ� ��ġ�� ������ ���´�.)
            // bulletInstance.transform.position = firePosition;
            bulletInstance.transform.position = firePosition.transform.position;

            // Bullet �߻� �Ҷ� ���� �ݹ� Sound�� ��µǰ� �ϰ� �ʹ�.

            // 2. Audio Source�� Sound Clip�� Play �Ѵ�.
            if(firesound != null)
            {
                firesound.Play();
               // firesound.Stop();
               // firesound.Pause();
            }
        }

        // Keyboard�� ���� Key 1���� ������ �ݹ� Sound�� Sound1 Clip���� ��µǰ� �ϰ�,
        // 1. ������� �Է�(����Ű 1)�� �޴´�.
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            firesound.clip = sounds[0];
        }

        // Keyboard�� ���� Key 2���� ������ �ݹ� Sound�� Sound2 Clip���� ��µǰ� �Ѵ�.
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            firesound.clip = sounds[1];
        }
    }
}
