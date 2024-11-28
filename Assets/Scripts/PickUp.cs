using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickUpGamePlay.instance.PickUpItem();
            Destroy(gameObject);
        }
    }
}
