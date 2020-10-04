using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject cubeObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //CheckCube();

            //This is supposed to access the resources folder in living birds and instantiate the cardinal.
            
            GameObject instance = Instantiate(Resources.Load("lb_cardinalHQ"), transform.position, 
                Quaternion.Euler(0, 180, 0)) as GameObject;
            

        }
    }

    void CheckCube()
    {
        string cubeClicked = cubeObject.tag;
        switch (cubeClicked)
        {
            case "CardinalCube":
                Debug.Log("red cube");
                break;
            case "GoldfinchCube":
                Debug.Log("yellow cube");
                break;
            default:
                Debug.Log("no cube");
                break;
        }

    }
}
