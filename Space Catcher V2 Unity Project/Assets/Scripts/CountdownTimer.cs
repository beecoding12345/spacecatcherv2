using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    //gets the starting time and the loading time
    float currentTime = 0f;
    float startingTime = 300f;

    [SerializeField] Text CountdownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        CountdownText.text = currentTime.ToString("0");


        if (currentTime <= 0)
            currentTime = 0;
        {
            //SceneManager.SetActiveScene("GameLosingScreen");
        }
    }
}
