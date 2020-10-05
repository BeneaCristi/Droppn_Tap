using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{

    public GameObject[] enemies;


    
    

    private float timeBetweenSpawns;
    public float startTimteBetweenSpawns;
    public float decreaseTime;
    public float minTime;


    private void Update()
    {
        if (timeBetweenSpawns <= 0)
        {
            GameObject thisObject = Instantiate(enemies[Random.Range(0, enemies.Length)], transform.position, Quaternion.identity);
            
            timeBetweenSpawns = startTimteBetweenSpawns;

            if(startTimteBetweenSpawns > minTime)
            {
                startTimteBetweenSpawns -= decreaseTime;
            }
           
        }
        else
        {
            timeBetweenSpawns -= Time.deltaTime;
        }

        
    }


}
