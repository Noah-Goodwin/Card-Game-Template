using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Red_Mush : MonoBehaviour
{
    Animator m_Animator;
    private float walkspeed;
    public TextMeshProUGUI Redwin;
    public TextMeshProUGUI Bluewin;
    public TextMeshProUGUI Tie;
    // Start is called before the first frame update
    void Start()
    {
        walkspeed = 1.30f;
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(walkspeed*Time.deltaTime, 0f, 0f, Space.Self);
       
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("B_Zombie"))
        {
            m_Animator.SetBool("Death", true);
        }

        if (col.gameObject.CompareTag("B_Knight"))
        {
            m_Animator.SetBool("MushA", true);
            Redwin.text = "RED WINS";
        }
        
        
        if (col.gameObject.CompareTag("B_Mush"))
        {
            m_Animator.SetBool("Tie", true);
            Tie.text = "TIE";
        }
       
    }

     void death()
     {
         Destroy(gameObject);
     }

     void endA()
     {
         walkspeed = 1.30f;
         m_Animator.SetBool("MushA", false);
     }
     
}
