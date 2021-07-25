using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmButton : MonoBehaviour
{

    public GameObject confirmButton;
    public GameManager gameManager;
    private bool isInteractable = false;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        confirmButton.GetComponent<Button>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.cardPoints == 0 && gameManager.cardsReady == 3)
        {
            isInteractable = true;
            if(isInteractable)
            {
                confirmButton.GetComponent<Button>().interactable = true;
            }
        }
    }
}
