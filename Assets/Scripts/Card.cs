using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    
    public Sprite sprite;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI costText;
    public TextMeshProUGUI damageText;
    public Image spriteImage;
    
        

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = data.card_name;
        descriptionText.text = data.description;
        healthText.text = data.health.ToString();
        costText.text = data.cost.ToString();
        damageText.text = data.damage.ToString();
        spriteImage.sprite = data.sprite;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
