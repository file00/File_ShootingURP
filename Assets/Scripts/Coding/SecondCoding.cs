using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SecondCoding : MonoBehaviour
{
    public int number1;
    public int number2;
    public bool isMan = true;

    // Start is called before the first frame update
    void Start()
    {
        #region
        //// ����, number1�� ���� number2�� ������ ũ��,
        //if (number1 > number2)
        //{
        //    // "number1�� ���� �� Ů�ϴ�!"��� ����Ѵ�.
        //    print("number1�� ���� �� Ů�ϴ�!");
        //}

        //// �׷��� �ʰ� ���� number1�� ���� number2�� ������ ������
        //else if (number1 < number2)
        //{
        //    // "number2�� ���� �� Ů�ϴ�!"��� ����Ѵ�.
        //    print("number2�� ���� �� Ů�ϴ�!");
        //}

        //// �׷��� �ʴٸ�...
        //else
        //{
        //    // "number2�� ���� number1�� �����ϴ�!"��� ����Ѵ�. 
        //    print("number2�� ���� number1�� �����ϴ�!");
        //}

        //// ����, isMan ������ ���� True��� "����"��� ����ϰ�, 
        //if (isMan == true)
        //{
        //    print("����");
        //}
        //// �׷��� �ʴٸ�, "����"��� ����Ѵ�.
        //else
        //{
        //    print("����");
        //}
        #endregion
        #region
        //// 1. "Hello!"��� ���ڿ��� 10ȸ ����Ѵ�.
        //for (int i = 0; i < 10; i++)
        //{
        //    print("Hello!");
        //}

        // 2. 1 ~ 10���� ����ϰ� �ʹ�.
        //for (int i = 0; i < 10; i++)
        //{
        //    print(i+1);
        //}


        // For���� �̿��ؼ� ������ 7���� ǥ���ϱ�
        //int i = 7;
        //int j;
        //for (j = 1; j < 10; j++)
        //{
        //   print(i*j);
        //}
        #endregion
        #region
        // Class ������ ���� and New Class Instance ����
        //FirstCoding myInstance = new FirstCoding();
        //myInstance.number2 = 3.5f;
        //int result = myInstance.Add(10, 20);       
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
