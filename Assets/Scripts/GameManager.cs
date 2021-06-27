using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
