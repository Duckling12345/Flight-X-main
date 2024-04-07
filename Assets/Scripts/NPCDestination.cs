using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDestination : MonoBehaviour
{
    public GameObject removePassenger;
    public GameObject removePassenger1;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Passenger"))
        {
            removePassenger.SetActive(false);
            Object.Destroy(removePassenger1);
            Debug.Log("Passenger entered collider");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        removePassenger.SetActive(false);
        removePassenger1.SetActive(false);

    }
}