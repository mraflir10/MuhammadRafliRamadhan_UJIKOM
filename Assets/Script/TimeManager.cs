
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float timer = 60;
    public bool timesUp = false;
    public GameObject gameOverUI;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Debug.Log("Waktu Habis");
            timer = 0;
            timesUp = true; 

            GameOver();
        }
    }

    void StartCountdown()
    {
        timer = 60;
    }

    void GameOver()
    {

        if(gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }
    }
}
