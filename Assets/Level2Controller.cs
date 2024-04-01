using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Controller : MonoBehaviour
{
    //public FixedSeatBeltButton fixedSeatBelt;
    //public SeatBelt seatBelt;

    public FixedSitButton fixedSitButton;
    public ChairInteraction chairInteraction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //seatBelt.Pressed = fixedSeatBelt.Pressed;
        chairInteraction.Pressed = fixedSitButton.Pressed;
    }
}
