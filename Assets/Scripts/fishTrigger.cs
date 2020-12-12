using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishTrigger : MonoBehaviour
{

    public GameObject fish;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            scoreScript.scoreValue += 100;
            Destroy(fish);
        }
    }
}
