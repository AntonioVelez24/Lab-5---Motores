using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public GameObject audioPanel;
    private bool activePanel = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetPanel()
    {
        if (activePanel == false)
        {
            activePanel = true;
            audioPanel.SetActive(true);
        }
        else 
        {
            activePanel = false;
            audioPanel.SetActive(false);
        }
    }
}
