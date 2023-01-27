using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameWinningScreen : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("GameLevelScreen");
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }


  
}

