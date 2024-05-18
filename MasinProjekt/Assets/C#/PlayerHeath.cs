using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour


{
    public float PlayerHealth = 100;
    // Start is called before the first frame update
  public LogicManager logic;
  
    void Start(){
   
 logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); 
    // Update is called once per frame
   }
   void Update()
   {if(logic.PlayerHealth <= 0)
        {
            Die();
        }
        void Die()
        {
            logic.gameOver();
            Destroy(gameObject);
            Debug.Log("smrt");
            Time.timeScale = 0;

        }}
      
}
