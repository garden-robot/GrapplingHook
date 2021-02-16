using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingSpot: MonoBehaviour
{
    public bool isFishing = false;

    bool isCaught;

    public GameObject Fish;

    public List<GameObject> fishList;

    // Start is called before the first frame update
<<<<<<< HEAD

=======
<<<<<<< HEAD

=======
    void Start()
    {

    }
>>>>>>> main
>>>>>>> parent of aa90f09... Merge remote-tracking branch 'origin/main' into main

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FishingHook")
        {
<<<<<<< HEAD
            Fish = null;
=======
<<<<<<< HEAD
            Fish = null;
=======
>>>>>>> main
>>>>>>> parent of aa90f09... Merge remote-tracking branch 'origin/main' into main
            isFishing = true;
            Debug.Log("Begin fishing");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "FishingHook" && isFishing == true)
        {
            Debug.Log("Still fishing");
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> parent of aa90f09... Merge remote-tracking branch 'origin/main' into main
       
    }

    private void OnTriggerExit(Collider other)
    {

        if (isCaught)
        {
            Debug.Log("Caught a fish! Glub glub!");

            Debug.Log(Fish);

        }
        else
        {
            Debug.Log("No fishies. :(");

        }

        isCaught = false;

    }

    void Update()
    {
<<<<<<< HEAD
=======
=======
>>>>>>> main
>>>>>>> parent of aa90f09... Merge remote-tracking branch 'origin/main' into main
        if (Input.GetKeyDown(KeyCode.R))
        {
            isFishing = false;
            Debug.Log("Begin reeling in");
            bool randomCatch = (Random.value > 0.5f);
            int randomValue = Random.Range(0, fishList.Count);

            isCaught = randomCatch;
            Fish = fishList[randomValue];
        }
    }
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

    private void OnTriggerExit(Collider other)
    {
            
            if (isCaught)
            {
                Debug.Log("Caught a fish! Glub glub!");
                Debug.Log(Fish);
           
            }
            else
            {
                Debug.Log("No fishies. :(");
            }
      

    }
>>>>>>> main
>>>>>>> parent of aa90f09... Merge remote-tracking branch 'origin/main' into main
}
