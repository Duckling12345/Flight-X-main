using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairInteraction : MonoBehaviour
{
    public GameObject sitButton;
    public GameObject standButton; // Button to stand up
    public Camera mainCamera;
    public Camera sittingCamera;

    public GameObject player; // The player GameObject
    public GameObject sittingPlayer; // The sitting player GameObject

    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting


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


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sitButton.SetActive(true);
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
}