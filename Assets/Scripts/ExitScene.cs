using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    public GameObject disableButton;
    public UnlockDoor nextScene;
    

    private void OnTriggerEnter(Collider other)
    {
        disableButton.SetActive(false);
        nextScene.NextLevel();
    }
}
