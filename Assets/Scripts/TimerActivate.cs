using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerActivate : MonoBehaviour
{
    public NPCScript npc;
    public GameObject gameOver;
    public GameObject Level;
    private void Update()
    {
        if(npc.talkPressed)
        {   
            gameOver.SetActive(true);
            Level.SetActive(true);
        }
    }

}
