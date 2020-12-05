using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class experimentalController : MonoBehaviour
{

    public Texture2D tex;

    [SerializeField]private Vector2 velocity;
    [SerializeField]private Rigidbody2D rb2d;
    
    [SerializeField]private SpriteRenderer sr;

  
    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.AddComponent<SpriteRenderer>();
        rb2d = gameObject.AddComponent<Rigidbody2D>();

        velocity = new Vector2(1.75f, 1.1f);
        sr.color = new Color(0.9f, 0.9f, 0.0f, 1.0f);

        transform.position = new Vector3(-2.0f, -2.0f, 0.0f);
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + velocity * Time.fixedDeltaTime);
    }
}
