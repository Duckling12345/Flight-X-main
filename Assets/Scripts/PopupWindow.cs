using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PopupWindow : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Scene scene;
    public GameObject ObjectiveNotification;
    public GameObject window;
    private Animator popupAnimator;
    private Coroutine queueChecker;
    public TMP_Text popupText;
    public List<ObjectiveList> objectiveList;
    private Queue<string> popUpQueue;
    public TMP_Text[] texts;
    public bool clipPressed;
    private int currentObjectives;
    private ObjectiveScript objectiveScript;




    private void Start()
    {
        TexttoArray();
        scene = SceneManager.GetActiveScene();
        popupAnimator = window.GetComponent<Animator>();
        popUpQueue = new Queue<string>();
        Debug.Log(currentObjectives);

        //switch case gets the current scene displays pop up based on current scene;
        switch (scene.buildIndex)
        {
            case 6:
                ShowPopup("How to Play");
                break;

            case 8:
                ShowPopup("Fire On Board");
                break;

            case 10:
                ShowPopup("Loss of Pressurization");
                break;

            default:
                ShowPopup("Test Scene- Testing");
                break;
        }


        //for scenes
        /** for scenes
         if (scene.buildIndex == 6)
         {
             ShowPopup("Board the Plane");
         }
         else if(scene.buildIndex == 8) {
             ShowPopup("Fire On Board");
         }
         else
             ShowPopup("Test Scene- Testing");**/
    }
    private void Update()
    {
        if (clipPressed && scene.buildIndex == 6)
        {
            ShowPopup("Board the Plane");
        }
        else if (clipPressed)
        {
            ShowPopup("Test Scene - Testing");
        }
    }

    public void AddtoQueue(string objectives)
    {
        popUpQueue.Enqueue(objectives);
        if (queueChecker == null)
        {
            queueChecker = StartCoroutine(CheckQueue());
        }
    }
    public void ShowPopup(string objectives)
    {
        window.SetActive(true);
        popupText.text = objectives;
        popupAnimator.Play("PopUpAnimation");
        Debug.Log("Printed Objective");
    }

    private IEnumerator CheckQueue()
    {
        do
        {
            ShowPopup(popUpQueue.Dequeue());
            do
            {
                yield return null;
            } while (!popupAnimator.GetCurrentAnimatorStateInfo(0).IsTag("Idle"));
        } while (popUpQueue.Count > 0);
        window.SetActive(false);
        queueChecker = null;
    }

    void TexttoArray()
    {
        //currentObjectives = objectiveScript.objectives.Count;
        int childCount = ObjectiveNotification.transform.childCount;
        texts = new TMP_Text[childCount];

        for (int i = 0; i < childCount; i++)
        {
            texts[i] = ObjectiveNotification.transform.GetChild(i).GetComponent<TMP_Text>();
            texts[i].text = objectiveList[i].Object;
        }
    }



    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        clipPressed = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        clipPressed = false;
    }
}
