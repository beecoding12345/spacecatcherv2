using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelScreen : MonoBehaviour 
{ 
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    public float screenBoundsX;

    void Start()
    {
        StartCoroutine(asteroidWave());
    }

    private void spawnEnemy() 
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBoundsX, screenBoundsX), transform.position.y);
    }

    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

    

    
}
