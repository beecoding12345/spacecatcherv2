using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLosingScreen : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void Quit()
    {
        Application.Quit();
    }
}
