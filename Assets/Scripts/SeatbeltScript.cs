using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SeatbeltScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool Pressed;
    public FixedSeatbeltButton fixedSeatbelt;
    [SerializeField] Animator BuckleAnim;
    public GameObject CameraAnimation;
    public string StateName;
    public GameObject tempDisable;
    public Shake shaker;

    void Update()
    {
        if (fixedSeatbelt.Pressed)
        {
            shaker.ShakeScreen();
            FastenSeatbelt();
        }
    }
    void FastenSeatbelt()
    {
        CameraAnimation.SetActive(true);
        BuckleAnim.Play(StateName);
        tempDisable.SetActive(false);
        //AudioManager.Instance.PlayBuckleSound();
    }
    private void OnTriggerExit(Collider other)
    {
        CameraAnimation.SetActive(false);
        tempDisable.SetActive(true);
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