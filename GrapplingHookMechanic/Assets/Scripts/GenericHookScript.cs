using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericHookScript : MonoBehaviour
{
    public Vector3 originalPosition;
    public GameObject hook;

    private bool retract = false;

    public float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        //This is so we know what place to pull the hook back to at the end of any action
        //it is referenceable everywhere
        originalPosition = hook.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            retract = true;
        }

        if (retract == true)
        {
            hook.transform.localPosition = Vector3.MoveTowards(
                hook.transform.localPosition,
                originalPosition,
                Time.deltaTime * speed);
        }
        
    }
}
