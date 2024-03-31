using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObj : MonoBehaviour, IInteractable
{
    [SerializeField] Animator transitionAnim;
    public GameObject activate;
    public void Interact()
    {
        activate.SetActive(true);
        transitionAnim.Play("FadeIn");
        AudioManager.Instance.PlayInspectSound();
    }

    private void OnTriggerExit(Collider other)
    {
        activate.SetActive(false);
    }
}
