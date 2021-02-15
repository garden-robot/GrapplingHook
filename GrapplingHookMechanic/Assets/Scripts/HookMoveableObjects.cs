using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMoveableObjects : MonoBehaviour
{
    GameObject hookedObj = null;

    public Camera cam;
    
    public GameObject hook;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 fwd = cam.transform.TransformDirection(Vector3.forward) * 30;
        Debug.DrawRay(transform.position, fwd, Color.red);
        
        if (Input.GetMouseButtonDown(0) && GenericHookScript.retract == false && hook.transform.childCount == 0)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                
                if (Physics.Raycast(ray, out hit))
                {

                    Debug.Log( hit.collider.gameObject.name);
                    
                    if (hit.collider != null && hit.collider.gameObject.tag == "HookableObjects")
                    {
                        hook.GetComponent<MeshRenderer>().enabled = true;
                        hook.transform.position = hit.collider.gameObject.transform.position;
                        hit.collider.transform.SetParent(hook.transform);
                        hit.collider.enabled = false;
                    }
                }
        }

        if (GenericHookScript.originalPosition == hook.transform.localPosition && hook.transform.childCount == 1)
        {
            hook.transform.GetChild(0).GetComponent<Collider>().enabled = true;
            hook.transform.DetachChildren();
            hook.GetComponent<MeshRenderer>().enabled = false;

        }
        
    }
}
