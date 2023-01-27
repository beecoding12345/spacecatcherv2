using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;


    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.tag == "MyAsteroid")
        {

            ScoreNum -= 1;
            Destroy(other.gameObject);
            MyscoreText.text = "Score" + ScoreNum;

            
           


        }

        if (other.tag == "MySpaceship")
        {
            ScoreNum += 1;
            Destroy(other.gameObject);
            MyscoreText.text = "Score" + ScoreNum;
        }

        if (ScoreNum  >=35)
        {
            SceneManager.LoadScene("GameWinningScreen");
        }



    }


}
