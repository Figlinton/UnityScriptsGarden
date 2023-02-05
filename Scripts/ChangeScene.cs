using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // void OnCollisionEnter(Collision collision)
    //     {
    //         //Check for a match with the specified name on any GameObject that collides with your GameObject
    //         // if (collision.tag == "TriggerChangeLevel")
    //         // {
    //         //     //If the GameObject's name matches the one you suggest, output this message in the console
    //         //     Debug.Log("Do something here");
    //         // }
    //         Debug.Log("Do something here");
    //     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 18.8){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // void OnCollisionEnter(Collision collision)
        // {
        //     //Check for a match with the specified name on any GameObject that collides with your GameObject
        //     if (collision.gameObject.name == "TriggerChangeLevel")
        //     {
        //         //If the GameObject's name matches the one you suggest, output this message in the console
        //         Debug.Log("Do something here");
        //     }
        // }
    }
}
