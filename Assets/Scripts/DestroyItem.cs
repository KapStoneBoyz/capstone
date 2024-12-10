using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DestroyItem : MonoBehaviour
{
    public PickUp item;
    public PickUpGamePlay gamePlay;
    public TMP_Text blanket;

    public void PickUpObject()
    {
        gamePlay.PickUpItem();
        Destroy(item.gameObject);
    }
    public void ChangeTextColor()
    {
        blanket.color = Color.green;
    }


}
