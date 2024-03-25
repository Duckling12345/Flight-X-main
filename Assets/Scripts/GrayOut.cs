using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GrayOut : MonoBehaviour
{
    public TMP_Text objectiveText1;
    public FixedButton fixbutton;
    public ObjectiveScript objective;

    private void Update()
    {
       if (fixbutton.Pressed == true && objective.objectivesDone == 2)
        {
            objectiveText1.color = new Color32(0xC0, 0xC0, 0xC0, 0xFF);
        }
    }

}
