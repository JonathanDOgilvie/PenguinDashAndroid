using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float movementSpeed = 0.5f;


    private CharacterController characterControllerReference;
    private Vector2 moveDirection_V2 = Vector2.zero;
    // Start is called before the first frame update
    void Start()
    {
        characterControllerReference = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0.0f, 2.3f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0.0f, -2.3f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-2.3f, 0.0f, 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(2.3f, 0.0f, 0.0f);
        }
    }
}
