using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject ZombieRight;
    public GameObject ZombieLeft;
     public GameObject ZombieTankRight;
     public GameObject ZombieTankLeft;
    public Transform ZombieSpawnerRight;
    public Transform ZombieSpawnerLeft;
    public float SpawnRate = 2;
    public float SpawnRateTank1= 10;
    public float SpawnRateTank2= 15;
    private float Timer = 0;
    private float TimerTank1 = 0;
    private float TimerTank2 = 0;
    public float SpawnModifier = 50 ;
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
           
        }
        else
        {
             SpawnZombieLeft();
            SpawnZombieRight();
             Timer = 0;
             if(SpawnRate >=1.25){SpawnRate= SpawnRate - (SpawnRate/SpawnModifier);}
             Debug.Log("-");
        }
         if(TimerTank1 < SpawnRateTank1)
         {
            TimerTank1 = TimerTank1 + Time.deltaTime;
         }
            else
            {
                SpawnZombieTankLeft();
                TimerTank1=0;
            } 
          if(TimerTank2 < SpawnRateTank2)
         {
            TimerTank2 = TimerTank2 + Time.deltaTime;
         }
            else
            {
                SpawnZombieTankRight();
                TimerTank2=0;
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
   void SpawnZombieTankRight()
   {
    Instantiate(ZombieTankRight, ZombieSpawnerRight.position, Quaternion.Euler (0f, 180, 0f));
   }
void SpawnZombieTankLeft()
{
    Instantiate(ZombieTankLeft, ZombieSpawnerLeft.position, ZombieSpawnerLeft.rotation);
}
    }

