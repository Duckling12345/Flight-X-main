using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChairInteraction : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public GameObject sitButton;
    public FixedSitButton fixedSitbutton;
    public Camera mainCamera;
    public Camera sittingCamera;
    public  bool Pressed;
    public GameObject player; // The player GameObject
    public GameObject sittingPlayer; // The sitting player GameObject
    public Shake shaker;
    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting

    private void OnTriggerEnter(Collider other)
    {
      
        if (fixedSitbutton.Pressed)
        {
            Sit();
            shaker.ShakeScreen();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sitButton.SetActive(false);
        }
    }

    public void Sit()
    {
        // Store the current position of the player before sitting
        lastPlayerPosition = player.transform.position;

        // Deactivate the main camera and activate the sitting camera
        mainCamera.gameObject.SetActive(false);
        sittingCamera.gameObject.SetActive(true);

        // Activate the sitting player and deactivate the standing player
        sittingPlayer.SetActive(true);
        player.SetActive(false);

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


