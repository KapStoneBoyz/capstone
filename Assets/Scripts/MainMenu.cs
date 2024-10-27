using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject VolumePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayClick()
    {
        SceneManager.LoadScene("LivingRoomCutScene");
    }
    public void OnVolumePanelClick()
    {
        Debug.Log("Click");
        if (!VolumePanel.activeSelf)
        VolumePanel.SetActive(true);

    }
    public void OnVolumeBack()
    { 
        VolumePanel.SetActive(false);
        
    }
}
