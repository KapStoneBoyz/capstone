using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    public GameObject pickUpBtn;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pickUpBtn.SetActive(true);
            pickUpBtn.GetComponent<DestroyItem>().item = this;
        }
    }

    
}
