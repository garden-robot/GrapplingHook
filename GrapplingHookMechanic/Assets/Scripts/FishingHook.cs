using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSpotContact : MonoBehaviour
{
    bool isFishing;

    bool fishCaught;

    //List of Fish

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TesTag")
        {
            isFishing = true;
            Debug.Log("Begin fishing");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "FishingSpot" && isFishing == true)
        {
            Debug.Log("Still fishing");
        }

        if (isFishing == false)
        {
            Debug.Log("Begin reeling in");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (fishCaught)
        {
            Debug.Log("Caught a fish! Glub glub!");
        }
        else
        {
            Debug.Log("No fishies. :(");
        }

    }
}
