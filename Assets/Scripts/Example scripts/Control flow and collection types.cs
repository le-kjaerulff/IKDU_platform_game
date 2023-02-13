using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlflowandcollectiontypes : MonoBehaviour
{
    


    // Start is called before the first frame update
    void Start()
    {
        int currentGold = 50;
        CheckWallet(currentGold);

        int[] exampleArrayOfIntegers = { 1, 3, 4 };  // fast way of declaring array and assigning values. Lenght value is implicitly statet.  
        int[] anotherExampleArrayOfIntegers = new int[3] { 1, 2, 3, };  // slow way of declaring array and assigning values

        exampleArrayOfIntegers[2] = 5; // 4 is changed to 5 on index 2. 

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckWallet(int paramA)
    {
        if (paramA > 50)
        {
            Debug.Log("u are rich");
        }
        else
        {
            Debug.Log("u are poor, get back 2 the grind");
        }
    }

}
