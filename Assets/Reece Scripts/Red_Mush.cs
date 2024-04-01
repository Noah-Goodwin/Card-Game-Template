using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Mush : MonoBehaviour
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

     void OnCollisionEnter2D(Collision2D col)
    {
        

        if (col.gameObject.CompareTag("B_Knight"))
        {
            m_Animator.SetBool("MushA", true);
        }
        else
            walkspeed = 0.30f;
        m_Animator.SetBool("MushA", false);
        
    }
}
