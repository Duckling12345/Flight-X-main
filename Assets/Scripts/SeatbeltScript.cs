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

    void Update()
    {
        if (fixedSeatbelt.Pressed)
            FastenSeatbelt();
    }
    void FastenSeatbelt()
    {
        BuckleAnim.Play("Fasten seatbelt of first passenger");
        //AudioManager.Instance.PlayBuckleSound();
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
