using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject audioPanel;
    public GameObject exitPanel;
    public GameObject mainMenu;
    private bool activeAudioPanel = false;
    private bool activeExitPanel = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetAudioPanel()
    {
        if (activeAudioPanel == false)
        {
            activeAudioPanel = true;
            audioPanel.SetActive(true);
            mainMenu.SetActive(false);
        }
        else 
        {
            activeAudioPanel = false;
            audioPanel.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
    public void SetExitPanel()
    {
        if (activeExitPanel == false)
        {
            activeExitPanel = true;
            exitPanel.SetActive(true);
            mainMenu.SetActive(false);
        }
        else
        {
            activeExitPanel = false;
            exitPanel.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
    public void ExitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
