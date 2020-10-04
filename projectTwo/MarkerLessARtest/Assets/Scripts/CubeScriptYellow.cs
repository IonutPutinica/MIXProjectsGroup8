using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScriptYellow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //This is supposed to access the resources folder in living birds and instantiate the cardinal.
            GameObject instance = Instantiate(Resources.Load("lb_goldFinchHQ"), transform.position,
                Quaternion.Euler(0, 180, 0)) as GameObject;
        }
    }
}
