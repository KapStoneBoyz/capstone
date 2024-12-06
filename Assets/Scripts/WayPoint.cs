using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WayPoint : MonoBehaviour
{
    public Image img;
    public Transform target;
    public void Update()
    {
        img.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    }

    
}
