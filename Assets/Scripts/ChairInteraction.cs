using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairInteraction : MonoBehaviour
{
    public GameObject sitButton;
    public FixedButton fixbutton; //temporary will add new button;
    public Camera mainCamera;
    public Camera sittingCamera;

    public GameObject player; // The player GameObject
    public GameObject sittingPlayer; // The sitting player GameObject

    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting



    private void Update()
    {
        if (fixbutton.Pressed)
        {
            Sit();
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


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sitButton.SetActive(true);
        }
    }


 }
