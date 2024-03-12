using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;
using Unity.PlasticSCM.Editor.WebApi;

public class NPCScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public NPCConversation myConversation;
    public bool talkPressed;
    public GameObject talkButton;
    private PopupWindow popupWindow;

    public GameObject objectiveText1;
    public GameObject objectiveText2;
    void Start()
    {
        talkButton.SetActive(false);
        // add objectives 
    }
 
    private void Update()
    {
        StartConversation();
    }
  
    void StartConversation()
    {
        if (talkPressed)
        {
            ConversationManager.Instance.StartConversation(myConversation);
            }
    }

    private void OnTriggerEnter(Collider other)
    {
        talkButton.SetActive(true);
        ShowText();
    }
    public void ShowText()
    {
       objectiveText1.SetActive(true);
       objectiveText2.SetActive(true);

    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        talkPressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        talkPressed = false;
    }
}
