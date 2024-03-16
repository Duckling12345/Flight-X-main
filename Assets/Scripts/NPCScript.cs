using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.EventSystems;
using Unity.PlasticSCM.Editor.WebApi;
using Palmmedia.ReportGenerator.Core;
using System.Linq;
using UnityEngine.UI;

public class NPCScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public NPCConversation myConversation;
    public bool talkPressed;
    public GameObject talkButton;
    private PopupWindow popupWindow;
    private ObjectiveScript objectiveScript;
    public GameObject objectiveText1;
    public GameObject objectiveText2;


    [HideInInspector]
    public int finished;

    void Start()
    {
        talkButton.SetActive(false);

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
            finishedTask();
        }
    }
    void finishedTask()
    {
        finished++;
        //Debug.Log("text has been hidden: " + finished);
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

    private void OnTriggerExit(Collider other)
    {
        talkButton.SetActive(false);
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
