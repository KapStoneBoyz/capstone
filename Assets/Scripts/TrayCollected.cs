using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrayCollected : MonoBehaviour
{
    public DialogueManager endDialog;
    public List<GameObject> toys;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Toy"))
        {
            if(toys.Contains(other.gameObject))
                toys.Remove(other.gameObject);

            if(toys.Count == 0)
            {
                EndGame();
            }
            Debug.Log(other.gameObject.name);
        }
    }

    private void EndGame()
    {
        endDialog.gameObject.SetActive(true);
    }
}
