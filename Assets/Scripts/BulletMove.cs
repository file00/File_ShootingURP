using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // 총알을 위로 계속 이동하게 하고 싶다.
    // Direction = Up, Size = Move Speed
    public float moveSpeed = 10;
    public GameObject explosionPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        // 총알을 위로 계속 이동하게 하고싶다.
        // Vector3 dir = Vector3.up;

        // 총알의 이동방향을 나의 위쪽 방향으로 이동하게 설정한다.
        // Vector3 dir = new Vector3(0, 1, 0);
        Vector3 dir = transform.up;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // If, 충돌이 발생한다면..
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // 상대방 Object를 제거한다.
    //    Destroy(collision.gameObject);

    //    // 나를 제거한다.    
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        // If, 충돌한 대상의 게임 Object의 이름이 "Enemy"라는 문자열을 포함하고 있다면..
        if (other.gameObject.name.Contains("Enemy"))
        {
            // 폭발 Effect를 생성한다.
            GameObject go = Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);

            if(go != null)
            {
                // 폭발 Effect Object에서 Particle System이라는 Component를 가져온다.
                ParticleSystem explosionFX = go.GetComponent<ParticleSystem>();

                // Particle을 Play 한다.
                explosionFX.Play();
            }

            // 상대방 Object를 제거한다.
            Destroy(other.gameObject);
        }
        // 나를 제거한다.    
        Destroy(gameObject);
    }
}
