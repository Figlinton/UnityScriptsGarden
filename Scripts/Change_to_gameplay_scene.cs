using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_to_gameplay_scene : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "TriggerChangeLevel")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");
        }
    }
}
