using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScanScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{

    public GameObject scanButton;
    public GameObject goBackButton; // Button to stand up

    public FixedBackButton fixedBackbutton;
    public FixedScanButton fixedscanbutton;

    public Camera mainCamera;
    public Camera scanCamera;
    public bool Pressed;
    public GameObject player; // The player GameObject
    public GameObject lookCapsule; // The sitting player GameObject
    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting

    private void Update()
    {
        if (fixedscanbutton.Pressed)
        {
            Sit();
        }
        else if (fixedBackbutton.Pressed)
        {
            Stand();
        }
    }


    public void Sit()
    {
        // Store the current position of the player before sitting
        lastPlayerPosition = player.transform.position;

        // Deactivate the main camera and activate the sitting camera
        mainCamera.gameObject.SetActive(false);
        scanCamera.gameObject.SetActive(true);

        // Activate the sitting player and deactivate the standing player
        lookCapsule.SetActive(true);
        player.SetActive(false);

        // Activate the stand button
        goBackButton.SetActive(true);
    }

    public void Stand()
    {
        // Deactivate the sitting camera and activate the main camera
        scanCamera.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);

        // Deactivate the sitting player and activate the standing player
        lookCapsule.SetActive(false);
        player.SetActive(true);

        // Move the player back to the last position before sitting
        player.transform.position = lastPlayerPosition;

        // Disable the stand button
        goBackButton.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        lookCapsule.SetActive(false);
        player.SetActive(true);

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }

}
