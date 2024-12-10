using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomGamePlay : MonoBehaviour
{
    public DialogueManager endDialog;
    public DialogueManager wrongDialog;
    public WellDoneScreenManager starManager;
    public CollectedBox box1;
    public CollectedBox box2;

    public void CheckCollected()
    {
        if (box1.items.Count == 0 && box2.items.Count == 0) {
            End();
        }
    }
    public void End()
    {
        endDialog.gameObject.SetActive(true);
        starManager.Show();
    }
}
