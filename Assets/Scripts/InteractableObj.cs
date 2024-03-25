using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableObj : MonoBehaviour, IInteractable
{

   
    public void Interact()
    {
        Debug.Log(Random.Range(0, 100));
    }

}
