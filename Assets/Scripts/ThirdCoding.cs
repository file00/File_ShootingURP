using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdCoding : MonoBehaviour
{
    public string firstName = "ÀÌ¼ø½Å";
     
    // Start is called before the first frame update
    void Start()
    {
        // Local Variable
        string firstName = "Yeon";
        print(firstName);
    }

    // Update is called once per frame
    void Update()
    {
        string firstName = "Soo";

        print(this.firstName);
    }

    void TestFunc()
    {
        print(firstName);
    }
}
