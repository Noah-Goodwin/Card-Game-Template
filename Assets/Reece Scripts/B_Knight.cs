using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class B_Knight : MonoBehaviour
{
    private Animator m_Animator;
    private float walkspeed;
    // Start is called before the first frame update
    void Start()
    {
        walkspeed = -0.30f;
        GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(walkspeed*Time.deltaTime, 0f, 0f, Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        walkspeed = 0;
        m_Animator.SetBool("interact", true);
        //if()
        //{
        //}
    }
}
