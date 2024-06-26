using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Quest : MonoBehaviour
{
    public int questNumber;
    public int[] items;
    public GameObject[] clouds;
    public GameObject barrier;
    public GameObject key;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag != "Player" && other.gameObject.GetComponent<Pickap>().id == items[questNumber])
        {
            questNumber++;
            Destroy(other.gameObject);
            CheckQuest();
        }
    }

    public void CheckQuest()
    {
        for(int i = 0; i < clouds.Length; i++)
        {
            if(i == questNumber)  
            {
                clouds[i].SetActive(true);
                clouds[i].GetComponent<Animator>().SetTrigger("isTriggered");
                break;
            }
            else
            {
                clouds[i].SetActive(false);
            }
            if(questNumber == 3)
            {
                barrier.SetActive(false);
            }
            if(questNumber == 4)
            {
                key.SetActive(true);
            }
        }
    }
}
