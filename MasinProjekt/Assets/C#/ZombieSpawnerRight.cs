using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawnerRight : MonoBehaviour
{
    public GameObject ZombieRight;
    public float SpawnRate = 2;
    private float Timer = 0;
    // Start is called before the first frame update
    void Start()
    {
         SpawnZombieRight();
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer < SpawnRate)
        {
            Timer = Timer + Time.deltaTime;
            Debug.Log("+");
        }
        else
        {
            SpawnZombieRight();
             Timer = 0;
        }
    }
    void SpawnZombieRight()
    {
     Instantiate(ZombieRight, transform.position, transform.rotation);
    }

}
