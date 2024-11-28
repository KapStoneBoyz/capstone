using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text textArea;

    [TextArea(3, 10)]
    public string[] dialogue;
    public Animator transition;
    private int index = 0;
    public string nextScene;
    public void Start()
    {
        NextDialogue();
    }
    public void OnClick()
    {
        NextDialogue();
    }

    IEnumerator TypeSentence (string sentence)
    {
        textArea.text = "";
        foreach (char s in sentence.ToCharArray())
        {
            textArea.text += s;
            yield return null;
        }
    }

    public void NextDialogue()
    {
        if (index >= dialogue.Length)
        {
            transition.enabled = true;
            if(nextScene == "")
            {
                gameObject.SetActive(false);
            }
            else
            {
                StartCoroutine(ChangeScreen());
            }
            
        }
        else
        {
            StartCoroutine(TypeSentence(dialogue[index]));
            index++;
        }
    }

    IEnumerator ChangeScreen()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(nextScene);
    }
}
