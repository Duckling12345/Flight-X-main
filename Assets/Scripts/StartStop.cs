using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class StartStop : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;



    private void Start()
    {
        player = GetComponent<VideoPlayer>();
    }


    private void Update()
    {
        
    }

    public void StartPlay()
    {
        if (player.isPlaying == false)
        {
            player.Play();
        }
        else
        {
            player.Pause();
        }
    }
}
