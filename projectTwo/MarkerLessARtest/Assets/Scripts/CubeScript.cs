using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject controller;
    //lb_BirdController birdController;
    //lb_Bird bird;

    Ray ray;
    RaycastHit hit;
    

    // Start is called before the first frame update
    void Start()
    {
        //birdController = GameObject.FindObjectOfType<lb_BirdController>();
        //bird = GameObject.FindObjectOfType<lb_Bird>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                CheckCube();

                //This is supposed to access the resources folder in living birds and instantiate the cardinal.
                /*
                GameObject instance = Instantiate(Resources.Load("lb_cardinalHQ"), transform.position,
                    Quaternion.Euler(0, 180, 0)) as GameObject;
                
                GameObject instance = Instantiate(Resources.Load("lb_cardinalHQ"), hit.point,
                    Quaternion.identity) as GameObject;
                */
                //Debug.Log(hit.transform.tag);
            }
        }

    }

    void CheckCube()
    {
        string cubeClicked = hit.transform.tag;
        switch (cubeClicked)
        {
            case "cardinal":
                Debug.Log("red cube");
                GameObject instanceCard = Instantiate(Resources.Load("lb_cardinalHQ"), hit.point,
                    Quaternion.Euler(0, 180, 0)) as GameObject;
                break;
            case "goldfinch":
                Debug.Log("yellow cube");
                GameObject instanceFinch = Instantiate(Resources.Load("lb_goldFinchHQ"), hit.point,
                    Quaternion.Euler(0, 180, 0)) as GameObject;
                break;
            case "bluejay":
                Debug.Log("blue cube");
                GameObject instanceJay = Instantiate(Resources.Load("lb_blueJayHQ"), hit.point,
                    Quaternion.Euler(0, 180, 0)) as GameObject;
                break;
            case "robin":
                Debug.Log("rust red cube");
                GameObject instanceRobin = Instantiate(Resources.Load("lb_robinHQ"), hit.point,
                    Quaternion.Euler(0, 180, 0)) as GameObject;
                break;
            default:
                Debug.Log("no cube");
                break;
        }

    }
}
