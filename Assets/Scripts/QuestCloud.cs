using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class QuestCloud : MonoBehaviour
{
    public Animator[] clouds;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach(Animator anim in clouds)
            {
                anim.SetTrigger("isTriggered");
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            foreach (Animator anim in clouds)
            {
                anim.SetTrigger("isTriggered");
            }
        }
    }
}
