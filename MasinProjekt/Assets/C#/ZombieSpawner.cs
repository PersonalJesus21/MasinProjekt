using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject ZombieRight;
    public GameObject ZombieLeft;
    public Transform ZombieSpawnerRight;
    public Transform ZombieSpawnerLeft;
    public float SpawnRate = 2;
    private float Timer = 0;
    // Start is called before the first frame update
    
    void Start()
    {
         SpawnZombieRight();
         SpawnZombieLeft();
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
            SpawnZombieLeft();
            SpawnZombieRight();
             Timer = 0;
        }
    }
    void SpawnZombieRight()
    {
     Instantiate(ZombieRight, ZombieSpawnerRight.position, Quaternion.Euler (0f, 180f, 0f));
    }
   void SpawnZombieLeft()
    {
    Instantiate(ZombieLeft, ZombieSpawnerLeft.position, ZombieSpawnerLeft.rotation);
    }
   
    }

