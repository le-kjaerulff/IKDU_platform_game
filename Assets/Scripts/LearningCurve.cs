using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int currentAge = 55;


    // Start is called before the first frame update
    void Start()
    {
        int ageIncrement = 1;

        int newAge;
       
        newAge = ComputeAge(currentAge, ageIncrement);

        Debug.Log(newAge);

    }

    // Update is called once per frame
    void Update()
    {

    }
    int ComputeAge(int a, int b)
    {
        int result = a + b;
        return result;
    }


}
