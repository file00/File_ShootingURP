using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{   
    // 정수형 변수를 선언
    public int number;
    // 실수형 변수를 선언
    public float number2;
    // 문자열 변수를 선언
    public string myName = "Yeon";
    // 논리형 변수를 선언
    public bool isMan;

    
    void Start()
    {
        // number = 10;
        // number2 = 3.141592f;
        // myName = "Yeon";
        // myName = "Handsome";
        // isMan = true;

        // 변수의 값을 출력한다.
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

    // 함수를 선언
    // 두 숫자(정수)를 재료로 받아서 두 정수의 합을 결과 값으로 반환하는 함수
    // 반환 자료형 함수 이름 (매개변수1, 매개변수2...)
    // {
    //  해야할 일
    //  return 결과 값;
    // }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // 뺄셈(Subtract), 곱셈(Multiply), 나눗셈(Divide)
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
        // 나눗셈 연산자
        // 1. 몫 (연산자 == /)
        // 2. 나머지 (연산자 == %)
        return num1 % num2;
    }

}
