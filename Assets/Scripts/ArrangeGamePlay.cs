using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrangeGamePlay : MonoBehaviour
{
    public GameObject blanket;
    public GameObject matress;
    public GameObject pillow1;
    public GameObject pillow2;
    public DialogueManager correct;
    public DialogueManager wrong;

    public int[] arrangement = new int[4];
    public int index;
    public WellDoneScreenManager starManager;
    public void PlaceButtonOnClick(int buttonID)
    {
        arrangement[index] = buttonID - 1;
        index++;
        switch(buttonID)
        {
            case 1:
                blanket.SetActive(true);
                break;
            case 2:
                matress.SetActive(true);
                break;
            case 3:
                pillow1.SetActive(true);
                break;
            case 4:
                pillow2.SetActive(true);
                break;
        }
        if(index == 4)
        {
            if(CheckAcceptedAnswer( new int[] { 1, 2, 3, 0 }))
            {
                correct.gameObject.SetActive(true);
                starManager.Show();
            }
            else if(CheckAcceptedAnswer( new int[]{ 1, 3, 2, 0 }))
            {
                correct.gameObject.SetActive(true);
                starManager.Show();
            }
            else
            {
                wrong.gameObject.SetActive(true);
            }
        }
    }

    private bool CheckAcceptedAnswer(int[] acceptedAnswer)
    {
        
        for(var i=0;i<acceptedAnswer.Length;i++)
        {
            Debug.Log(arrangement[i]);
            if (acceptedAnswer[i] != arrangement[i])
            {

                return false;
            }
        }
        return true;
    }
}
