using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovementLeft : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = 45;
    void Start()
    {
        
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
