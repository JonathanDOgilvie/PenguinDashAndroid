using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resumeButton : MonoBehaviour
{

    public GameObject pauseMenuUI;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(ResumeToggle);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumeToggle()
    {
        
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
