using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButon : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClickToStart()
    {
        Debug.Log("Start Game!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    // Update is called once per frame
    public void ClickToQuit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
        
    }
    public void ClickToHome()
    {
        SceneManager.LoadScene(0);
    }
}
