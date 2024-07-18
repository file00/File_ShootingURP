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
        //// 만일, number1의 값이 number2의 값보다 크면,
        //if (number1 > number2)
        //{
        //    // "number1의 값이 더 큽니다!"라고 출력한다.
        //    print("number1의 값이 더 큽니다!");
        //}

        //// 그렇지 않고 만일 number1의 값이 number2의 값보다 작으면
        //else if (number1 < number2)
        //{
        //    // "number2의 값이 더 큽니다!"라고 출력한다.
        //    print("number2의 값이 더 큽니다!");
        //}

        //// 그렇지 않다면...
        //else
        //{
        //    // "number2의 값이 number1과 같습니다!"라고 출력한다. 
        //    print("number2의 값이 number1과 같습니다!");
        //}

        //// 만일, isMan 변수의 값이 True라면 "남자"라고 출력하고, 
        //if (isMan == true)
        //{
        //    print("남자");
        //}
        //// 그렇지 않다면, "여자"라고 출력한다.
        //else
        //{
        //    print("여자");
        //}
        #endregion
        #region
        //// 1. "Hello!"라는 문자열을 10회 출력한다.
        //for (int i = 0; i < 10; i++)
        //{
        //    print("Hello!");
        //}

        // 2. 1 ~ 10까지 출력하고 싶다.
        //for (int i = 0; i < 10; i++)
        //{
        //    print(i+1);
        //}


        // For문을 이용해서 구구단 7단을 표현하기
        //int i = 7;
        //int j;
        //for (j = 1; j < 10; j++)
        //{
        //   print(i*j);
        //}
        #endregion
        #region
        // Class 변수의 선언 and New Class Instance 생성
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
