using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Red_Zombie : MonoBehaviour
{
    Animator m_Animator;
    public float Red_walkspeed;
    public SpawnButton blue;
    
    // Start is called before the first frame update
    void Start()
    {
        blue = GameObject.FindWithTag("Z_Button").GetComponent<SpawnButton>();
        Red_walkspeed = 0f;
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool("Red_Move", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("test"))
        {
            Red_walkspeed = 0f;
            m_Animator.SetBool("Red_Attack", true);
            blue.Spawned = false;
        }
    }
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");
        if (col.gameObject.CompareTag("B_Knight"))
        {

            Red_walkspeed = 0;
            m_Animator.SetBool("Red_Death", true);
            blue.Spawned = false;
            
            
        }
<<<<<<< Updated upstream
        
        Debug.Log("Hit");
        if (col.gameObject.CompareTag("B_Zombie"))
=======
        if (col.gameObject.CompareTag("B_Knight"))
>>>>>>> Stashed changes
        {

            Red_walkspeed = 0;
            m_Animator.SetBool("Red_Death", true);
            blue.Spawned = false;
            
        }

    }

    void Death()
    {
        Destroy(gameObject);
    }
    void endA()
    {
        Red_walkspeed = -0.30f;
        m_Animator.SetBool("Red_Attack", false);
    }
}
