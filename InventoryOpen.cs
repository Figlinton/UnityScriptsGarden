using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryOpen : MonoBehaviour
{
    public GameObject inventoryMenu;
    public GameObject firstPersonCamera;
    [SerializeField] KeyCode inventoryOpenKey;
    bool isInventoryMenu = false;

    private void Start()
    {
        inventoryMenu.SetActive(false);
    }

    private void Update()
    {
        InventoryMenu();
    }

    void InventoryMenu()
    {
        if (Input.GetKeyDown(inventoryOpenKey))
        {
            isInventoryMenu = !isInventoryMenu;
        }
        if (isInventoryMenu)
        {
            inventoryMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            inventoryMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
