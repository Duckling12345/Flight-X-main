using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Controller : MonoBehaviour
{
    public FixedSeatbeltButton fixedSeatbelt;
    public SeatbeltScript seatbelt;

    public FixedSitButton fixedSitButton;
    public ChairInteraction chairInteraction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seatbelt.Pressed = fixedSeatbelt.Pressed;
        chairInteraction.Pressed = fixedSitButton.Pressed;
    }
}
