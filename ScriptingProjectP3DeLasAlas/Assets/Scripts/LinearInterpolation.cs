using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    /*
   
    *Creates float variable, result, containing 50% between
    *3 and 5. 5-3=2 and 50% of 2 = 1, so result contains 3+1=4
    float result = Mathf.Lerp(3f, 5f, 0.5f);

    *Creates Vector3 variables containing starting and ending vectors
    *(from and to)
    Vector3 from = new Vector3(1f, 2f, 3f);
    Vector3 to = new Vector3(5f, 6f, 7f);

    // Start is called before the first frame update
    void Start()
    {
    *Creates Vector3 variable, result, containing result of 75% of the
    *differnce between from and to
    Vector3 result = Vector3.Lerp(from, to, 0.75f);

    }

    // Update is called once per frame
    void Update()
    {
    *Creates Lerp function to smooth value over time; 
    *Function light.intensity contains value of 50% of the difference 
    *between initial light intensity and 8
    light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
    }
    */
}
