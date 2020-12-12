using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerHealth : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;

    public Canvas deathUI;

    public healthBar playerhealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        playerhealth.SetMaxHealth(maxHealth);
        deathUI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth == 0)
        {
            deathUI.enabled = true;
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PolarBear")
        {
            TakeDamage(1);
        }

        if (other.tag == "Seal")

        {
            TakeDamage(1);
        }

        if (other.tag == "Icicle")
        {
            TakeDamage(1);
        }

        if (other.tag == "Fish")
        {
            GiveHealth(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerhealth.SetHealth(currentHealth);
    }

    void GiveHealth(int heal)
    {
        currentHealth += heal;
        playerhealth.SetHealth(currentHealth);
    }

}
