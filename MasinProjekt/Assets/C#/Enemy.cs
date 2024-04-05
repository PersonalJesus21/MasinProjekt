using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Enemy : MonoBehaviour

{
   
    public float pdamage = 25;
    public int health = 100;
    public LogicManager logic;
    public GameObject deathEffect;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); 
    }
    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            
        }
    }
    
    void Die ()
    {
        Destroy(gameObject);
        logic.AddScore();
    }
    void Update()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHeath>().PlayerHealth -= pdamage;
             logic.DecreaseHealth();
        }
        
    }
}


