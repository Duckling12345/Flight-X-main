using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public FireScript fireScript;
    public UnlockDoor sceneMover;

    // Update is called once per frame
    void Update()
    {
        if (fireScript.isLit == false)
        {
            sceneMover.NextLevel(); 

        }
    } 
    
}
