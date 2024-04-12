using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Blue_Zombie : MonoBehaviour
{
    Animator m_Animator;
    private float walkspeed;
    // Start is called before the first frame update
    void Start()
    {
        walkspeed = -1.30f;
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool("Blue_Move", true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(walkspeed*Time.deltaTime, 0f, 0f, Space.Self);
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("test"))
        {
            walkspeed = 0;
            m_Animator.SetBool("Blue_Attack", true);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");
        if (col.gameObject.CompareTag("R_Knight"))
        {

            walkspeed = 0;
            m_Animator.SetBool("Death", true);

            
            
        }
        
        Debug.Log("Hit");
        if (col.gameObject.CompareTag("R_Zombie"))
        {

            walkspeed = 0;
            m_Animator.SetBool("Tie", true);

            
        }
        if (col.gameObject.CompareTag("Red_Mush"))
        {

            walkspeed = 0;
            m_Animator.SetBool("Blue_Attack", true);

            
            
        }

    }
    void death()
    {
        Destroy(gameObject);
    }

    void endA()
    {
        walkspeed = -1.30f;
        m_Animator.SetBool("Blue_Attack", false);
    }

}
