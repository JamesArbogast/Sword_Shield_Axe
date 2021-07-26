using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMgt : MonoBehaviour
{
     public Scene nextScene;

    public void GetNextScene()
    {
        SceneManager.LoadScene(nextScene.name);
    }
}
