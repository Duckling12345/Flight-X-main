using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WaypointManager : MonoBehaviour
{
    [System.Serializable]

    struct Data
    {
        public int totalWayPoints;
        public GameObject waypointCanvas;
        public GameObject worldWaypoints;
        public GameObject waypointUIPrefab;
        public List<GameObject> waypointPrefab;
    }
    [SerializeField] Data data;

    private void Awake()
    {
        for(int i =  0;  i< data.totalWayPoints; i++)
        {
                if(data.waypointPrefab.Count > 0)
            {
                for(int j = 0; j < data.waypointPrefab.Count; j++)
                {
                    GameObject tmpWaypoint = Instantiate(data.waypointPrefab[j]);
                    WaypointController tmpWaypointController = tmpWaypoint.GetComponent<WaypointController>();
                    GameObject tmpWayPointUI = Instantiate(data.waypointUIPrefab);
                    tmpWayPointUI.GetComponent<Image>().sprite = tmpWaypointController.waypointBaseController.data.item.icone;
                    tmpWayPointUI.transform.SetParent(data.waypointCanvas.transform);

                    tmpWaypointController.waypointBaseController.data.item.image = tmpWayPointUI.GetComponent<Image>();
                    tmpWaypointController.waypointBaseController.data.item.message = tmpWayPointUI.transform.GetChild(0).GetComponent<Text>();
                    tmpWaypointController.waypointBaseController.data.item.waypointUI = tmpWayPointUI;
                    tmpWaypointController.transform.SetParent(data.worldWaypoints.transform);
                    tmpWaypointController.transform.position = new Vector3(Random.Range(5, 995), 0.5f, Random.Range(5, 995));
                }
            }
        }
    }



}




