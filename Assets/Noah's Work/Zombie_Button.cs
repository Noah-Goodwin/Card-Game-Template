using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Zombie_Button : MonoBehaviour
{
    public GameObject prefab;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(prefab, transform.position, quaternion.identity);
    }
    
    
    
    
}
