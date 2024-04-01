using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_R_Knight : MonoBehaviour
{
    Animator m_Animator;
    private float walkspeed;
    // Start is called before the first frame update
    void Start()
    {
        walkspeed = 0.30f;
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(walkspeed*Time.deltaTime, 0f, 0f, Space.Self);
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("B_Zombie"))
        {
            walkspeed = 0;
            m_Animator.SetBool("MushA", true);
        }
        else m_Animator.SetBool("MushA", false);

        if (other.CompareTag("B_Knight"))
        {
            walkspeed = 0;
            m_Animator.SetBool("MushA", true);
        }
        else
            walkspeed = 0.03f;
        m_Animator.SetBool("MushA", false);
        
    }
    }

