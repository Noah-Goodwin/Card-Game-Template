using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Zombie_Button : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 spawnPoint;

    public bool Spawned;
    // Start is called before the first frame update
    void Start()
    {
        Spawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnZombie()
    {
        Instantiate(prefab, spawnPoint, quaternion.identity);
        Spawned = true;
        Destroy(gameObject);
    }


}
