using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    public List<Card> player_deck = new List<Card>();
    public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();
    public bool gameActive = false;
    public TextMeshProUGUI Redwin;
    public TextMeshProUGUI Bluewin;
    public TextMeshProUGUI Tie;
    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }

        gameActive = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        Redwin.text = " ";
        Bluewin.text = " ";
        Tie.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
     print(gameActive);   
    }

    void Deal()
    {

    }

    void Shuffle()
    {

    }

    void AI_Turn()
    {

    }



    
}
