using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairInteraction : MonoBehaviour
{
    public GameObject sitButton;
<<<<<<< HEAD
<<<<<<< HEAD
    public FixedSitButton fixedSitbutton;
    public Camera mainCamera;
    public Camera sittingCamera;
    public  bool Pressed;
=======
    public FixedButton fixbutton; //temporary will add new button;
    public Camera mainCamera;
    public Camera sittingCamera;

>>>>>>> parent of e6bedc5 (Update)
=======
    public FixedButton fixbutton; //temporary will add new button;
    public Camera mainCamera;
    public Camera sittingCamera;

>>>>>>> parent of e6bedc5 (Update)
    public GameObject player; // The player GameObject
    public GameObject sittingPlayer; // The sitting player GameObject

    private Vector3 lastPlayerPosition; // Store the last position of the player before sitting

    private void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD
<<<<<<< HEAD
      
        if (fixedSitbutton.Pressed)
=======
        if (fixbutton.Pressed)
>>>>>>> parent of e6bedc5 (Update)
=======
        if (fixbutton.Pressed)
>>>>>>> parent of e6bedc5 (Update)
        {
            Sit();
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


<<<<<<< HEAD
<<<<<<< HEAD

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
=======
    private void OnTriggerEnter(Collider other)
>>>>>>> parent of e6bedc5 (Update)
=======
    private void OnTriggerEnter(Collider other)
>>>>>>> parent of e6bedc5 (Update)
    {
        if (other.CompareTag("Player"))
        {
            sitButton.SetActive(true);
        }
    }
<<<<<<< HEAD
<<<<<<< HEAD
}


=======


 }
>>>>>>> parent of e6bedc5 (Update)
=======


 }
>>>>>>> parent of e6bedc5 (Update)
