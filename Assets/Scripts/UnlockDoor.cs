using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockDoor : MonoBehaviour
{
    public Transform fpsCamera;
    RaycastHit hit;
    public float Range = 3f;
    public DoorScript doorScript;
    public Animator Animation;
    public bool Opened;
    public bool Closed;
    public bool Pressed;

    private void Update()
    {
            if(Physics.Raycast(fpsCamera.position, fpsCamera.forward, out hit, Range))
        {
            if(hit.transform.tag == "Door")
            {
                doorScript = hit.transform.GetComponent<DoorScript>();
                if(doorScript != null)
                {
                    if (doorScript.Close)
                    {
                        if(Pressed)
                        {
                            Animation.SetBool("Opening", true);
                            Invoke("OpenTime", 0.30f);
                        }
                    }
                }
            }
        }
    }

    public void OpenTime()
    {
        doorScript.Close = false;
        doorScript.Open = true;
    }



}
