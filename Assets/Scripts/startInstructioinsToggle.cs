using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startInstructioinsToggle : MonoBehaviour
{

    public GameObject instructionsMenuUI;
    public GameObject mainMenuUI;
    

    // Start is called before the first frame update
    void Start()
    {
        instructionsMenuUI.SetActive(false);
        GetComponent<Button>().onClick.AddListener(ToggleInstructionsUI);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ToggleInstructionsUI()
    {
        mainMenuUI.SetActive(false);
        instructionsMenuUI.SetActive(true);
    }

    
}
