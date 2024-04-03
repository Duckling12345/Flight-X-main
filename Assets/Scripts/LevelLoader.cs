using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject image4;

    public Text title;


    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsyncronously(sceneIndex));
    }

    IEnumerator LoadAsyncronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;
        }
    }

    public void ChangeImage(int sceneIndex)
    {
        if (sceneIndex == 1 || sceneIndex == 3)
        {
            image1.SetActive(true);
            image2.SetActive(false);
            image3.SetActive(false);
            image4.SetActive(false);
        }
        else
        {
            image1.SetActive(false);
            image2.SetActive(true);
            image3.SetActive(false);
            image4.SetActive(false);
        }

    }

    public void ChangeText(int sceneIndex) {

        if (sceneIndex == 6) {
            title.text = "Preflight Checking | LEVEL 1";
        }else if (sceneIndex == 9)
        {
            title.text = "Loss of Pressurization | LEVEL 2";
        }else if (sceneIndex == 12)
        {
            title.text = "Fire on Board | LEVEL 3";
        }else 
        { title.text = "WATER LANDING | BOEING 787"; 
        }
    }

}