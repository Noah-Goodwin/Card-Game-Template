using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public GameObject prefab_zombie;
    public GameObject prefab_knight;
    public GameObject prefab_mushroom;
    public Vector3 spawnPoint;
    public bool game_active;

    public bool Spawned;
    // Start is called before the first frame update
    void Start()
    {
        game_active = false;
        Spawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnZombie()
    {
        Instantiate(prefab_zombie, spawnPoint, quaternion.identity);
        Spawned = true;
        game_active = true;
        //Destroy(gameObject);
    }
    
    public void SpawnKnight()
    {
        Instantiate(prefab_knight, spawnPoint, quaternion.identity);
        Spawned = true;
        game_active = true;
        //Destroy(gameObject);
    }
    
    public void SpawnMushroom()
    {
        Instantiate(prefab_mushroom, spawnPoint, quaternion.identity);
        Spawned = true;
        game_active = true;
        //Destroy(gameObject);
    }



}
