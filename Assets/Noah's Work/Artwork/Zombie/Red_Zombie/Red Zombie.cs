using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Red_Zombie : MonoBehaviour
{
    Animator m_Animator;
     float Red_walkspeed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        Red_walkspeed = 1.3f;
        m_Animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Red_walkspeed*Time.deltaTime, 0f, 0f, Space.Self);
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("test"))
        {
            Red_walkspeed = 0f;
            m_Animator.SetBool("Red_Attack", true);
           
        }
    }
    
    
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");
        if (col.gameObject.CompareTag("B_Knight"))
        {

            Red_walkspeed = 0;
            m_Animator.SetBool("Red_Death", true);
            
            
            
        }

        if (col.gameObject.CompareTag("B_Zombie"))

        {

            Red_walkspeed = 0;
            m_Animator.SetBool("Tie", true);
            
            
        }
        

        if (col.gameObject.CompareTag("B_Mush"))

        {

            Red_walkspeed = 0;
            m_Animator.SetBool("Red_Attack", true);
            
            
        }

    }

    void Death()
    {
        Destroy(gameObject);
    }
    void endA()
    {
        Red_walkspeed = 1.30f;
        m_Animator.SetBool("Red_Attack", false);
    }
}
