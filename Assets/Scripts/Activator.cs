using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public FixedExtinguishButton fixedExtinguish;
    public GameObject Extinguish;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Extinguisher();
    }

    void Extinguisher ()
    {
        if (fixedExtinguish.buttonPressed)
        {
            Extinguish.SetActive(true);  
        }
    }



}