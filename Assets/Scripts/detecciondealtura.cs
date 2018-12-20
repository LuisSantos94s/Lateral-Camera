using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecciondealtura : MonoBehaviour
{
    RaycastHit hit;
    public float distanciaRay;
    public GameObject player;
    public Camera camara;


    
   
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 fwd = player.transform.TransformDirection(Vector3.up);
        Debug.DrawRay(player.transform.position, fwd *distanciaRay , Color.red);
        Debug.Log (hit.distance);
        if (Physics.Raycast(player.transform.position, fwd, out hit, Mathf.Infinity))
        {

            if (hit.distance < distanciaRay)
            {
                camara.depth = 0;       
            }
            else if (hit.distance >= distanciaRay) 
            {
                camara.depth = -2;            
            }
        }

    }
}