using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int cardPoints = 0;
    public Text cardPointsText;
    IDictionary<string, int> cardValues = new Dictionary<string, int>();
    public class Player
    {
        public string Name { get; set; }
        public int GreenCard { get; set; }
        public int BlueCard { get; set; }
        public int PurpleCard { get; set; }
        public Player(string name, int greenCard, int blueCard, int purpleCard)
        {
            Name = name;
            GreenCard = greenCard;
            BlueCard = blueCard;
            PurpleCard = purpleCard;
        }
    }
    private enum GameState
    {
        INTRO,
        PREP,
        CHOOSE,
        BATTLE,
        DAMAGE,
        END
    }

    private GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        cardPoints = 100;
        //change this to intro once the intro is done
        gameState = GameState.PREP;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameState);
        switch (gameState)
        {
            
            case GameState.INTRO:
                Console.WriteLine("Game state: Intro");
                //Set up intro to game, cards come out animation. 
                //Asks if you need a tutorial. 
                //If its first time go right to tutorial.
                //Introduce enemy and or opponent.
                //create players name if it isn't already created
                break;
            case GameState.PREP:
                Console.WriteLine("Game state: Prep");
                //Bring cards close and add assign animation.
                //Create card classes
                //Assign power amount to each card in increments of ten. 
                //They draw from a total amount of power (100)
                //Add confirmation that the totals are correct.
                cardPointsText.text = cardPoints.ToString();
                break;
            case GameState.CHOOSE:
                Console.WriteLine("Game state: CHOOSE");
                break;
            case GameState.BATTLE:
                Console.WriteLine("Game state: BATTLE");
                break;
            case GameState.DAMAGE:
                Console.WriteLine("Game state: DAMAGE");
                break;
            case GameState.END:
                Console.WriteLine("Game state: END");
                break;
        }
            
    }
    

    public void ConfirmCardVals(int greenCard, int blueCard, int purpleCard)
    {
        //start HERE tomorrow
    }
}
