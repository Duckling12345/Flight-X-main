using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    public FireScript fireScript;
    public UnlockDoor sceneMover;
    public ParticleSystem partikol;


    // Update is called once per frame
    void Update()
    {
        Invoke("FadetoBlack", 5f);
    } 
    private void FadetoBlack()
    {
        int numbers = partikol.particleCount;
        if (fireScript.isLit == false && numbers == 0)
        {   
            sceneMover.NextLevel();
            AudioManager.Instance.StopExtinguishSound();
        }
    }
    
}
