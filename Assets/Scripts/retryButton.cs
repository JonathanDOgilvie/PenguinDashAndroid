using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class retryButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(RetryGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryGame()
    {
        scoreScript.scoreValue = 0;
        SceneManager.LoadScene(1);
    }
}
