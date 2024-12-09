using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpGamePlay : MonoBehaviour
{
    public int itemCount = 4;
    public DialogueManager dialog;
    public VariableJoystick joystick;
    public CharMovementManager characterMovementManager;
    public static PickUpGamePlay instance;
    public WellDoneScreenManager starManager;
    public void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
            instance = this;
    }

    public void PickUpItem()
    {
        itemCount -= 1;
        if(itemCount <= 0)
        {
            joystick.gameObject.SetActive(false);
            characterMovementManager.StopCharacter();
            dialog.gameObject.SetActive(true);
            starManager.Show();
        }
    }
}
