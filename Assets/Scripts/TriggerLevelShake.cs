using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLevelShake : MonoBehaviour
{
    public NPCScript npc;
    public Shake shaker;

    void Update()
    {
        if(npc.talkPressed)
        {
            shaker.ShakeScreen();
        }
    }
}
