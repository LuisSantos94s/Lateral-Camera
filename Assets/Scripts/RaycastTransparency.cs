using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTransparency : MonoBehaviour
{
    RaycastHit hit;
    public float rayDistance;

    GameObject obj;
    Renderer objRenderer;
    public Material newMtl;
    Material oldMtl;

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayDistance))

        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            if (obj != hit.collider.gameObject)
            {
                if (obj != null)
                {
                    objRenderer.material = oldMtl;
                }

                obj = hit.collider.gameObject;
                objRenderer = obj.GetComponent<Renderer>();
                oldMtl = objRenderer.material;
                objRenderer.material = newMtl;
            }
        }
        else
        {
            if (obj != null)
            {
                objRenderer.material = oldMtl;
                obj = null;
            }
        }
    }
}
