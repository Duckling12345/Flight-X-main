using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class FoBManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    private void Update()
    {
        if(remainingTime  > 0)
        {
            remainingTime -= Time.deltaTime;
        } else if(remainingTime < 0)
        {
            timerText.color = Color.red;
            remainingTime = 0;
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{00:00}:{1:00}", minutes, seconds);

    }
    void GameOver()
    {
        //GameOver.setActive(true);
        //Time.timeScale = 0f;
    }

    void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void backToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level Modules");

    }

}
