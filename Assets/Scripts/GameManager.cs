using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // �̱��� �������� ����(Singletone)
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
