using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float attackDamage = 3;
    public float attackSpeed = 1;
    public float lastHit = 0;
    public PlayerHealth ph; 
    public bool touchingPlayer = false; 
    void Update()
    {
        if(touchingPlayer && Time.time - lastHit >= attackSpeed)
        {
            ph.takeDamage(attackDamage);
            lastHit = Time.time;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            touchingPlayer = true;
        }
    }

        private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            touchingPlayer = false;
        }
    }
}
