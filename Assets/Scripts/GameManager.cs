using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 싱글턴 패턴으로 구현(Singletone)
    public static GameManager gm;

    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int number;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
