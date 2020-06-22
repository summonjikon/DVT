using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayerHealth : MonoBehaviour
{

    public float health;
    public float maxHealth;
    public bool isDead = false;

    private PlayerMovement playerMovement; 
    public Slider healthBar;
    public Image HealthBarColor;
    public GameObject gameOverScreen; 


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        float healthPrecent = health / maxHealth;
        healthBar.value = 1 - healthPrecent;
        if(healthPrecent >= .5)
        {
            HealthBarColor.color = Color.green; 
        }
        else
        {
            HealthBarColor.color = Color.red; 
        }

        if(isDead)
        {
            playerMovement.enabled = false; 
            gameOverScreen.SetActive(true);
        }

    }

    public void takeDamage (float amt)
    {
        if(health - amt <= 0)
        {
            health = 0;
            isDead = true; 
        }
        else 
        {
            health = health - amt; 
        }
    }
}
