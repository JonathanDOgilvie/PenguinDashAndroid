using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuButton : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public Button pauseButton;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(GoToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMenu()
    {
        scoreScript.scoreValue = 0;
        pauseMenuUI.SetActive(false);
        pauseButton.enabled = false;
        SceneManager.LoadScene(0);

    }
}
