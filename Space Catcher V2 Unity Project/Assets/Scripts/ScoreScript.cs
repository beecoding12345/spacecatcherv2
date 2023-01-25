using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;


    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter(Collider Asteroid)
    {
        if (Asteroid.tag == "MyAsteroid")
        {

            ScoreNum -= 1;
            Destroy(Asteroid.gameObject);
            MyscoreText.text = "Score" + ScoreNum;


        }
    }

    private void OnTriggerEnter(Collider Spaceship)
    {
        if (Spaceship.tag == "MyAsteroid")
        {

            ScoreNum += 1;
            Destroy(Spaceship.gameObject);
            MyscoreText.text = "Score" + ScoreNum;


        }
    }


}
