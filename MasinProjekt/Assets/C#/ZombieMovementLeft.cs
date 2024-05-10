using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using JetBrains.Annotations;
using UnityEngine;

public class ZombieMovementLeft : MonoBehaviour

{
      public float Timer;
    public float moveSpeed = 5;
    public float deadZone = 45;
      public float SpeedModifier = 10;
     public LogicManager logic;

    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); 
    }

    // Update is called once per frame
    void Update()
    {
          transform.position = transform.position + (Vector3.right*moveSpeed) * Time.deltaTime;

        if(transform.position.x>deadZone)
        {
            Destroy(gameObject);
        }
       
  
    }
}
