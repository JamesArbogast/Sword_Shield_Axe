using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    private GameManager gameManager;
    public bool pointsConfirmed;
    public GameObject upArrow;
    public GameObject downArrow;
    public Text numberText;
    public int cardValue = 0;
    public int isReady = 0;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        cardValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(cardValue > 0)
        {
            isReady = 1;
            
        }
        else
        {
            isReady = 0;
        }
        numberText.text = cardValue.ToString();
    }
    //attached to arrows on click event
    public void UpdateCardValueUp()
    {
        if(gameManager.cardPoints > 0)
        {
            cardValue += 10;
            gameManager.cardPoints -= 10;
        }

        if(gameManager.cardPoints <= 0)
        {
            gameManager.cardPoints = 0;
        }
    }
    //attached to arrows on click event
    public void UpdateCardValueDown()
    {
        cardValue -= 10;
        if(cardValue >= 0)
        {
            gameManager.cardPoints += 10;
        }

        if (cardValue <= 0)
        {
            cardValue = 0;
        }

        if (gameManager.cardPoints >= 100)
        {
            gameManager.cardPoints = 100;
        }
    }


}
