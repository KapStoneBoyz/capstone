using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedBox : MonoBehaviour
{
    public BathroomGamePlay gamePlay;
    public List<GameObject> items;
    public List<GameObject> wrongItems;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            if (items.Contains(other.gameObject))
                items.Remove(other.gameObject);
            else if (wrongItems.Contains(other.gameObject))
            {
                gamePlay.wrongDialog.gameObject.SetActive(true);
                return;
            }

            if (items.Count == 0)
            {
                gamePlay.CheckCollected();
            }
            Debug.Log(other.gameObject.name);
        }
    }
}
