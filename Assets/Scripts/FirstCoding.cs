using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{   
    // ������ ������ ����
    public int number;
    // �Ǽ��� ������ ����
    public float number2;
    // ���ڿ� ������ ����
    public string myName = "Yeon";
    // ���� ������ ����
    public bool isMan;

    
    void Start()
    {
        // number = 10;
        // number2 = 3.141592f;
        // myName = "Yeon";
        // myName = "Handsome";
        // isMan = true;

        // ������ ���� ����Ѵ�.
        // print(isMan);

        int number1 = 50;
        int number2 = 20;
        int result, result1, result2, result3;
        //float result3;

        result = Add(number1, number2);
        result1 = Subtract(number1, number2);
        result2 = Multiply(number1, number2);
        result3 = DivIde(number1, number2);

        print(result);
        print(result1);
        print(result2);
        print(result3);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    // �Լ��� ����
    // �� ����(����)�� ���� �޾Ƽ� �� ������ ���� ��� ������ ��ȯ�ϴ� �Լ�
    // ��ȯ �ڷ��� �Լ� �̸� (�Ű�����1, �Ű�����2...)
    // {
    //  �ؾ��� ��
    //  return ��� ��;
    // }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // ����(Subtract), ����(Multiply), ������(Divide)
    int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    int DivIde(int num1, int num2)
    {
        // ������ ������
        // 1. �� (������ == /)
        // 2. ������ (������ == %)
        return num1 % num2;
    }

}
