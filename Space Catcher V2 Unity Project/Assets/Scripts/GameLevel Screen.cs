using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelScreen : MonoBehaviour { 
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height)
        StartCoroutine(asteroidWave());
        }
    private void spawnEnemy() {
        {
            GameObject a = Instantiate(asteroidPrefab) as GameObject;
            a.transform,position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds)
            }
    }    IEnumerator asteroidWave() {
        while (true) {
            yeild return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }

    
}
