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
        }
        else
        {
            image1.SetActive(false);
            image2.SetActive(true);
        }

    }

    public void ChangeText(int sceneIndex) {

        if (sceneIndex == 1) {
            title.text = "HOW TO PLAY | AIRBUS A320";
        }else if (sceneIndex == 12)
        {
<<<<<<< HEAD
            title.text = "Fire on Board | LEVEL 3";
        }else 

=======
            title.text = "FIRE ONBOARD | BOEING 787";
        }else if (sceneIndex == 10)
        {
            title.text = "LOSS OF PRESSURIZATION | AIRBUS A320";
        }else
>>>>>>> parent of e6bedc5 (Update)
        { title.text = "WATER LANDING | BOEING 787"; 
        }
    }

}