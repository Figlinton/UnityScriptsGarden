using UnityEngine;

public class Raycast_Cam : MonoBehaviour
{
    public GameObject textBox1;
    private Animator DoorAnim;
    bool DoorOpen = false;

    void Update()
    {
        // Create a ray from the center of the camera
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        // Declare a RaycastHit object to store information about the hit
        RaycastHit hit;
        
        // Perform the raycast
        if (Physics.Raycast(ray, out hit))
        {
            // Print the name of the object that was hit
            Debug.Log("Hit object: " + hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "shotgun1"){
                textBox1.SetActive(true);
                 if (Input.GetKeyDown("e"))
                {
                    // Perform some action when the space key is pressed
                    GameObject shotgun = GameObject.Find("shotgun1");
                    Destroy(shotgun);
                }
            }
            else{
                textBox1.SetActive(false);
            }

            if (hit.collider.gameObject.name == "Door"){
                textBox1.SetActive(true);
                if (Input.GetKeyDown("e") && DoorOpen == false)
                {
                    // Perform some action when the space key is pressed
                    GameObject door = GameObject.Find("Door");
                    DoorAnim = door.GetComponent<Animator>();
                    DoorAnim.SetTrigger("TrOpen");
                    DoorOpen = true;
                } else if (Input.GetKeyDown("e") && DoorOpen == true){
                    GameObject door = GameObject.Find("Door");
                    DoorAnim = door.GetComponent<Animator>();
                    DoorAnim.SetTrigger("TrClose");
                    DoorOpen = false;
                }
            }
            else{
                textBox1.SetActive(false);
            }
            //Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
    }
}