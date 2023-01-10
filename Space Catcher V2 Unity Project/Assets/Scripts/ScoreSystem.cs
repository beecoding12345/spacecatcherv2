using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

    public Text scoreDisplay;

    private int scoreValue = 0;

    public void AddScore(int toAdd) 
    { 

        scoreValue = scoreValue + toAdd;
        scoreDisplay.text = scoreValue.ToString();

    } 
}    
