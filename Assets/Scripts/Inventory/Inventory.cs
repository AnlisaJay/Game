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
        // ��������� inventory ��� ������
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
            // �������� inventory
            foreach (GameObject item in inventory)
            {
                item.SetActive(true);
            }
        }
        else if (inventoryOn == true)
        {
            inventoryOn = false;
            // ��������� inventory
            foreach (GameObject item in inventory)
            {
                item.SetActive(false);
            }
        }
    }
}
