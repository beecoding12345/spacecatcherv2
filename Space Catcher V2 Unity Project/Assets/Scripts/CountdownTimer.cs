using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    //gets the starting time and the loading time
    float currentTime = 0f;
    float startingTime = 180f;

    [SerializeField] Text CountdownText;

    

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");

        //code for when the timer hits 0 it stays at 0 and ends the game. And

        if (currentTime <= 0)
            
        {
            currentTime = 0;
            SceneManager.LoadScene("GameLosingScreen");
        }
    }
}
