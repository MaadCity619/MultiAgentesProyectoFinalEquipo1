using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopLight : MonoBehaviour
{
    // Start is called before the first frame update
    public int lightStatus;
    void Start()
    {
        turnGreen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void turnGreen()
    {
        lightStatus = 2;
        Debug.Log("Light is green");
    }

    public void turnYellow()
    {
        lightStatus = 1;
        Debug.Log("Light is yellow");
    }

    public void turnRed()
    {
        lightStatus = 0;
        Debug.Log("Light is red");
    }

}
