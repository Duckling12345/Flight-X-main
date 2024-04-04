using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class VestScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject ObjectToWear;
    public GameObject ExitStopper;
    public bool wearPressed;
    public TMP_Text objectiveText1;
    public FixedInflateButton fixbutton;
    public GameObject disableButton;
    public ObjectiveScript objective;
    public int objectiveID;
    public GameObject activateEnd;
  //  [SerializeField] Animator transitionAnim;
   



    private void Update()
    {
        if (fixbutton.Pressed == true && objective.objectivesDone == objectiveID)
        {
            Wear();
            objectiveText1.color = new Color32(0xC0, 0xC0, 0xC0, 0xFF);
        }
    }


    void Wear()
    {
        if (wearPressed)
        {
            ObjectToWear.SetActive(false);
            disableButton.SetActive(false);
            ExitStopper.SetActive(false);
            activateEnd.SetActive(true);
        }
 
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        wearPressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        wearPressed = false;
    }
}
