using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    // �Ѿ��� ���� ��� �̵��ϰ� �ϰ� �ʹ�.
    // Direction = Up, Size = Move Speed
    public float moveSpeed = 10;
    public GameObject explosionPrefab;

    void Start()
    {
        
    }

    void Update()
    {
        // �Ѿ��� ���� ��� �̵��ϰ� �ϰ�ʹ�.
        // Vector3 dir = Vector3.up;

        // �Ѿ��� �̵������� ���� ���� �������� �̵��ϰ� �����Ѵ�.
        // Vector3 dir = new Vector3(0, 1, 0);
        Vector3 dir = transform.up;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }

    // If, �浹�� �߻��Ѵٸ�..
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // ���� Object�� �����Ѵ�.
    //    Destroy(collision.gameObject);

    //    // ���� �����Ѵ�.    
    //    Destroy(gameObject);
    //}

    private void OnTriggerEnter(Collider other)
    {
        // If, �浹�� ����� ���� Object�� �̸��� "Enemy"��� ���ڿ��� �����ϰ� �ִٸ�..
        if (other.gameObject.name.Contains("Enemy"))
        {
            // ���� Effect�� �����Ѵ�.
            GameObject go = Instantiate(explosionPrefab, other.transform.position, other.transform.rotation);

            if(go != null)
            {
                // ���� Effect Object���� Particle System�̶�� Component�� �����´�.
                ParticleSystem explosionFX = go.GetComponent<ParticleSystem>();

                // Particle�� Play �Ѵ�.
                explosionFX.Play();
            }

            // ���� Object�� �����Ѵ�.
            Destroy(other.gameObject);
        }
        // ���� �����Ѵ�.    
        Destroy(gameObject);
    }
}
