using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Clicked_On_Main_Menu : MonoBehaviour
{
    public Button New_Game_Button;
    public GameObject Intro_Scene;
    // Start is called before the first frame update
    void Start()
    {
        New_Game_Button.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Nothing now. Here must be change scenes
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
