using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastObjective : MonoBehaviour
{
    public GameObject missingObjective;
    public FixedButton fixbutton;
    

    private void Update()
    {
        if (fixbutton.Pressed == true)
        {
            missingObjective.SetActive(true);
        }
    }



}
