using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{

    IDictionary<string, int> cardValues = new Dictionary<string, int>();
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
        gameState = GameState.INTRO;
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case GameState.INTRO:
                Console.WriteLine("Game state: Intro");
                //Set up intro to game, cards come out animation. 
                //Asks if you need a tutorial. 
                //If its first time go right to tutorial.
                //Introduce enemy and or opponent.
                break;
            case GameState.PREP:
                Console.WriteLine("Game state: Prep");
                //Bring cards close and add assign animation.
                //Create card classes
                //Assign power amount to each card in increments of ten. 
                //They draw from a total amount of power (100)
                //Add confirmation that the totals are correct.
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
}
