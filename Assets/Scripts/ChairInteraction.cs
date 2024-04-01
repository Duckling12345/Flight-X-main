using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChairInteraction : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
<<<<<<< Updated upstream
    public GameObject sitButton;
    public GameObject standButton; // Button to stand up
=======
    public FixedSitButton fixedSitbutton;
>>>>>>> Stashed changes
    public Camera mainCamera;
    public Camera sittingCamera;
     public  bool Pressed;
    public GameObject player; // The player GameObject
    public GameObject sittingPlayer; // The sitting player GameObject
    public Shake shaker;
    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting

    private void OnTriggerEnter(Collider other)
    {
<<<<<<< Updated upstream
        if (other.CompareTag("Player"))
        {
            sitButton.SetActive(true);
=======
        if (fixedSitbutton.Pressed)
        {
            Sit();
            shaker.ShakeScreen();
>>>>>>> Stashed changes
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sitButton.SetActive(false);
            standButton.SetActive(false); // Disable stand button when leaving the trigger area
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

        // Activate the stand button
        standButton.SetActive(true);
    }

<<<<<<< Updated upstream
    public void Stand()
    {
        // Deactivate the sitting camera and activate the main camera
        sittingCamera.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);

        // Deactivate the sitting player and activate the standing player
        sittingPlayer.SetActive(false);
        player.SetActive(true);

        // Move the player back to the last position before sitting
        player.transform.position = lastPlayerPosition;

        // Disable the stand button
        standButton.SetActive(false);
    }
}
=======

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }


}
>>>>>>> Stashed changes
