using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Destroy_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    private GameManager gm;
    
    
    
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        
    }
    

    
    // Update is called once per frame
    void Update()
    {
        if (gm.gameActive)
        {
            Destroy(gameObject);
        }
    }
}
