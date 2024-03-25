using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerActivate : MonoBehaviour
{
    public NPCScript npc;
    public GameObject gameOver;
    private void Update()
    {
        if(npc.talkPressed)
        {
            gameOver.SetActive(true);
        }
    }

}
