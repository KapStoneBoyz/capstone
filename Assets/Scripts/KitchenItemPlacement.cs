using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenItemPlacement : MonoBehaviour
{
    public int properItemID;
    public GameObject placedObject;
    public KitchenCookingGamePlay gamePlay;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Kitchen"))
        {
            if (other.GetComponent<KitchenItem>().itemID == properItemID)
            {
                other.gameObject.SetActive(false);
                placedObject.SetActive(true);
                gamePlay.PlacedItem();
            }
        }
    }
}
