using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameOverManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject GameOverMenu;
    public GameObject Timer;
    private void Update()
    {
        if(remainingTime  > 0)
        {
            remainingTime -= Time.deltaTime;

        } else if(remainingTime <= 0)
        {
            timerText.color = Color.red;
            remainingTime = 0;
            GameOver();
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00:00}:{1:00}", minutes, seconds);

    }
    void GameOver()
    {
        GameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }

   public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void backToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level Modules");

    }


    public void Activator()
    {
        Timer.SetActive(true);
    }
}
