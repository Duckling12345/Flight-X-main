using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnlockDoor : MonoBehaviour
{
    public int sceneBuildIndex;

   public void MoveScene()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }
   

}
