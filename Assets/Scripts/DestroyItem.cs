using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class DestroyItem : MonoBehaviour
{
    public PickUp item;
    public PickUpGamePlay gamePlay;
    

    public void PickUpObject()
    {
        gamePlay.PickUpItem();
        Destroy(item.gameObject);
    }
    


}
