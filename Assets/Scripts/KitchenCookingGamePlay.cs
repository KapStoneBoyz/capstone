using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenCookingGamePlay : MonoBehaviour
{
    public int remainingItem;
    public DialogueManager done;
    public WellDoneScreenManager starManager;

    public void PlacedItem()
    {
        remainingItem -= 1;
        if(remainingItem <= 0 )
        {
            done.gameObject.SetActive( true );
            starManager.Show();
        }
    }
}
