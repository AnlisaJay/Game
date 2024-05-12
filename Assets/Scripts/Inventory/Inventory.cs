using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject[] inventory;
    private bool inventoryOn;

    private void Start()
    {
        inventoryOn = false;
        // Выключаем inventory при старте
        foreach (GameObject item in inventory)
        {
            item.SetActive(false);
        }
    }

    public void Chest()
    {
        if (inventoryOn == false)
        {
            inventoryOn = true;
            // Включаем inventory
            foreach (GameObject item in inventory)
            {
                item.SetActive(true);
            }
        }
        else if (inventoryOn == true)
        {
            inventoryOn = false;
            // Выключаем inventory
            foreach (GameObject item in inventory)
            {
                item.SetActive(false);
            }
        }
    }
}
