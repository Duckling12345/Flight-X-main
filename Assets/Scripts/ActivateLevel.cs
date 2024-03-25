using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Cinemachine.DocumentationSortingAttribute;

public class ActivateLevel : MonoBehaviour
{
    public GameObject Level;
    public GameObject Replacement;
    public NPCScript npc;



    private void Update()
    {
        if (npc.talkPressed)
        {
            activateLevel();
        }

    }
    void activateLevel()
    {
        Level.SetActive(true);
        Replacement.SetActive(false);
    }
}
