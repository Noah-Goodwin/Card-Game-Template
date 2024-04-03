using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    public bool game_active;
    
    
    
    void Start()
    {
        game_active = false;
    }
    

    
    // Update is called once per frame
    void Update()
    {
        if (game_active=true)
        {
        Destroy(gameObject);
        }
    }
}
