using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidRightDoorInteraction : MonoBehaviour
{
    public GameObject checkButton;
    public GameObject goBackButton; // Button to stand up
    public Camera mainCamera;
    public Camera midRightWingCam;

    public GameObject player; // The player GameObject
    public GameObject checkDoors; // The sitting player GameObject

    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting

private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkButton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkButton.SetActive(false);
            goBackButton.SetActive(false); // Disable stand button when leaving the trigger area
        }
    }

    public void Check()
    {
        // Store the current position of the player before sitting
        lastPlayerPosition = player.transform.position;

        // Deactivate the main camera and activate the sitting camera
        mainCamera.gameObject.SetActive(false);
        midRightWingCam.gameObject.SetActive(true);

        // Activate the sitting player and deactivate the standing player
        checkDoors.SetActive(true);
        player.SetActive(false);

        // Activate the stand button
        goBackButton.SetActive(true);
    }

    public void GoBack()
    {
        // Deactivate the sitting camera and activate the main camera
        checkDoors.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);

        // Deactivate the sitting player and activate the standing player
        checkDoors.SetActive(false);
        player.SetActive(true);

        // Move the player back to the last position before sitting
        player.transform.position = lastPlayerPosition;

        // Disable the stand button
        goBackButton.SetActive(false);
    }
}
