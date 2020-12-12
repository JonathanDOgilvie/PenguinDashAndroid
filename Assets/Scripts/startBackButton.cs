using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startBackButton : MonoBehaviour
{

    public GameObject instructionsMenuUI;
    public GameObject mainMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(GoBackToMain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoBackToMain()
    {
        
        instructionsMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
}
