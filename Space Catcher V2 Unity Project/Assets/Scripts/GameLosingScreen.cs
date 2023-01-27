using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLosingScreen : MonoBehaviour
{
    public void ReturnToMainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
        
    }

    public void PlayAgainButton()
    {
        SceneManager.LoadScene("GameLevelScreen");
    }
}
