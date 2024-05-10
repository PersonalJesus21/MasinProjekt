using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Vector3 = UnityEngine.Vector3;
public class ZombieMovemntRight : MonoBehaviour
{
     public LogicManager logic;
    
    public float moveSpeed = 5;
    public float deadZone = -45;
    public float SpeedModifier = 100;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>(); 
    }
    


    void Update()
    {
        transform.position = transform.position + (Vector3.left*moveSpeed) * Time.deltaTime;

        if(transform.position.x<deadZone)
        {
            Destroy(gameObject);
        }
     
       
    }
    
    
}