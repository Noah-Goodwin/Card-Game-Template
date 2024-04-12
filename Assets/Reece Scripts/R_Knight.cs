using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class R_Knight : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("test"))
        {
            walkspeed = 0;
            m_Animator.SetBool("interact", true);
            Redwin.text = "RED WINS";
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Hit");
        if (col.gameObject.CompareTag("B_Mush"))
        {

            walkspeed = 0;
            m_Animator.SetBool("Death", true);
            Bluewin.text = "BLUE WINS";
        }
        if (col.gameObject.CompareTag("B_Knight"))
        {

            walkspeed = 0;
            m_Animator.SetBool("Tie", true);
            Tie.text = "TIE";
        }
        if (col.gameObject.CompareTag("B_Zombie"))
        {

            walkspeed = 0;
            m_Animator.SetBool("interact", true);
            
        }

    }
    void Delete()
    {
        Destroy(gameObject);
    }
    void endA()
    {
        walkspeed = 1.30f;
        m_Animator.SetBool("interact", false);
    }
}
