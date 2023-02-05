using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpen : MonoBehaviour
{
    public GameObject inventoryMenu;
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
        }
        else
        {
            inventoryMenu.SetActive(false);
        }
    }
}
