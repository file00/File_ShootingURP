using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // Mouse의 Left Button Click시 Bullet이 발사되게 하고 싶다.
    // 1. Bullet의 Prefab을 안다.
    public GameObject bulletPrefab;
    public GameObject[] firePosition = new GameObject[3];
    public AudioClip[] sounds = new AudioClip[2];

    AudioSource firesound;

    void Start()
    {
        // 1. Audio Source Component를 가져온다.(Caching)
        firesound = gameObject.GetComponent<AudioSource>();

        // Volume 0.1로 변경
        if (firesound != null)
        {
            firesound.volume = 0.1f;
        }
    }

    void Update()
    {
        // 2. Mouse Left Button의 Input(Mouse Button 누른 순간 1회)을 받는다.
        bool mouseInput = Input.GetButtonDown("Fire1");

        if(mouseInput)
        {
            // print("Mouse Left Button Click");

            // 3. Bullet의 생성 위치를 지정한다.
            // Vector3 firePosition = transform.position + new Vector3(0, 1, 0);

            for (int i = 0; i < firePosition.Length; i++)
            {
                // 4. Bullet Prefab을 Scene에 생성(Memory)한다.
                GameObject bulletInstance = Instantiate(bulletPrefab);

                // 5. 생성된 Bullet Instance의 위치를 앞서 설정한 위치로 변경한다.(총알을 총구 위치에 가져다 놓는다.)
                // bulletInstance.transform.position = firePosition;
                bulletInstance.transform.position = firePosition[i].transform.position;

                // 5-1. 생성된 Bullet의 방향이 총구의 방향대로 회전한다.
                bulletInstance.transform.rotation = firePosition[i].transform.rotation;
            }
            // Bullet 발사 할때 마다 격발 Sound가 출력되게 하고 싶다.

            // 2. Audio Source에 Sound Clip을 Play 한다.
            if(firesound != null)
            {
                firesound.Play();
               // firesound.Stop();
               // firesound.Pause();
            }
        }

        // Keyboard의 숫자 Key 1번을 누르면 격발 Sound가 Sound1 Clip으로 출력되게 하고,
        // 1. 사용자의 입력(숫자키 1)을 받는다.
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            firesound.clip = sounds[0];
        }

        // Keyboard의 숫자 Key 2번을 누르면 격발 Sound가 Sound2 Clip으로 출력되게 한다.
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            firesound.clip = sounds[1];
        }
    }
}
