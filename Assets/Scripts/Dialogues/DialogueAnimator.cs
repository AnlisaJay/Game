using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        dm.startAnim.SetBool("startOpen", true); // ���������� ������ �� startAnim
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        dm.startAnim.SetBool("startOpen", false); // ���������� ������ �� startAnim
        dm.EndDialogue();
    }
}
