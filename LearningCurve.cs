using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int CurrentAge = 30;
    public int addedAge = 1;
    int a = 5;
    int b = 7;
   


    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();     

    }
    void ComputeAge()
    {
        int d = a;
        int c = b;
        Debug.Log(CurrentAge + addedAge);
        Debug.Log(a + b);
        Debug.Log(a = b);
        Debug.Log(b = a);

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(CurrentAge + ageIncrease);
    }
}
