using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Add this line to include the UI namespace
using UnityEngine;
using UnityEngine.UI;

public class MaskInteraction : MonoBehaviour
{
    public Button wearButton; // Reference to the "Wear" button
    public GameObject mask; // Reference to the mask GameObject

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the sitting player
        if (other.CompareTag("SittingPlayer"))
        {
            // Enable the "Wear" button
            wearButton.interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the collider belongs to the sitting player
        if (other.CompareTag("SittingPlayer"))
        {
            // Disable the "Wear" button
            wearButton.interactable = false;
        }
    }

    // Method to handle the "Wear" button click event
    public void WearMask()
    {
        // Disable the mask GameObject
        mask.SetActive(false);
    }
}