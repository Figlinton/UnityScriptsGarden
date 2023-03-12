using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;   

public class GameMainMenu : MonoBehaviour
{
    public GameObject pauseGameMenu;
    [SerializeField] KeyCode keyPauseGame;
    bool isPauseGameMenu = false;

    private void Start()
    {
        pauseGameMenu.SetActive(false);
    }

    private void Update()
    {
        ActiveMenu();
    }

    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyPauseGame))
        {
            isPauseGameMenu = !isPauseGameMenu;
        }

        if (isPauseGameMenu)
        {
            pauseGameMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            
        }
        else
        {
            pauseGameMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }

    public void Resume()
    {
        isPauseGameMenu = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}