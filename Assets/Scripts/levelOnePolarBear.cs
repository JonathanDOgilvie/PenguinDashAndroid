using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelOnePolarBear : MonoBehaviour
{

    public Transform spawn = null;
    public GameObject player;
    public Text textToInteract;
    public Button buttonToInteract;

    // Start is called before the first frame update
    void Start()
    {
        textToInteract.enabled = false;
        buttonToInteract.enabled = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        textToInteract.enabled = true;
        other.transform.position = spawn.position;
        buttonToInteract.enabled = true;
    }
}
