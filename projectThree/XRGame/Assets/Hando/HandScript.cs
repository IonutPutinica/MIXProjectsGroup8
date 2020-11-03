using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    public GameObject openHand;
    public GameObject closedHand;
    public GameObject grabbedObjectPosition;
    public GameObject camera;

    SphereCollider openHandInteractionSphere;

    public AudioSource pootisTest;

    bool handOpenBool = true;
    bool holdingObject = false;
    bool canGrab = false;
    GameObject grabbedObject;


    // Start is called before the first frame update
    void checkForInteractiveObject()
    {
        RaycastHit hitInfo;
        if (Physics.Linecast(openHand.transform.position, openHand.transform.position+camera.transform.forward*1000,out hitInfo, 9))
        {
            pootisTest.Play();
            grabbedObject = hitInfo.collider.gameObject;
            holdingObject = true;
            print("Intersected obhect" + grabbedObject.name.ToString());
            
        }
        Debug.DrawLine(openHand.transform.position, openHand.transform.position + openHand.transform.forward * 100f, Color.red, 10f);
        Debug.DrawRay(openHand.transform.position, openHand.transform.forward);
    }

    void Start()
    {
        closedHand.GetComponent<Renderer>().enabled = false;
        closedHand.GetComponent<MeshCollider>().enabled = false;

        openHandInteractionSphere = openHand.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            handOpenBool = !handOpenBool;
            Debug.DrawLine(openHand.transform.position, openHand.transform.position + openHand.transform.forward * 100f, Color.red, 10f);
            Debug.DrawRay(openHand.transform.position, openHand.transform.forward);
            checkForInteractiveObject();

            if (!handOpenBool)
            {
                closedHand.GetComponent<Renderer>().enabled = true;
                closedHand.GetComponent<MeshCollider>().enabled = true;
                openHand.GetComponent<Renderer>().enabled = false;
            }
            else
            {
                closedHand.GetComponent<Renderer>().enabled = false;
                closedHand.GetComponent<MeshCollider>().enabled = false;
                openHand.GetComponent<Renderer>().enabled = true;
            }

            print(Physics.Linecast(camera.transform.position, camera.transform.position + camera.transform.forward.normalized * 1000f, 9));
        }
        

        if (holdingObject && !handOpenBool)
        {
            grabbedObject.transform.position = grabbedObjectPosition.transform.position;
        }
        else if (holdingObject && handOpenBool)
        {
            holdingObject = false;
            grabbedObject = null;
        }


    }
}
