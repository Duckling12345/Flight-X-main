using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject loadingScreen0;
    public GameObject loadingScreen1;
    public GameObject loadingScreen2;
    public GameObject loadingScreen3;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        
        switch (sceneIndex)
        {
            case 6:
                loadingScreen0.SetActive(true);
                break;
            case 9:
                loadingScreen1.SetActive(true);
                break;
            case 12:
                loadingScreen2.SetActive(true);
                break;
            case 15:
                loadingScreen3.SetActive(true);
                break;
        }

       
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            
            yield return null;
        }

    
        SceneLoad(sceneIndex);
    }

    public void SceneLoad(int sceneIndex)
    {
        switch (sceneIndex)
        {
            case 6:
               
                break;
            case 9:
               
                break;
            case 12:
               
                break;
            case 15:
               
                break;
        }
    }
}
