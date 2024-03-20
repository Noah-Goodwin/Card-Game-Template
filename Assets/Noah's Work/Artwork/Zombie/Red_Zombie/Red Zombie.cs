using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Red_Zombie : MonoBehaviour
{
    Animator m_Animator;
    public float Red_walkspeed;
    public bool Spawned;
    
    // Start is called before the first frame update
    void Start()
    {
        Red_walkspeed = 1.00f;
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.SetBool("Red_Move", true);
    }

    // Update is called once per frame
    void Update()
    {
        
        //Red_walkspeed = 1.00f;
        transform.Translate(Red_walkspeed*Time.deltaTime, 0f, 0f, Space.Self);
       
    }
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("test"))
        {
            Red_walkspeed = 0;
            m_Animator.SetBool("Red_Attack", true);
        }
    }
}
