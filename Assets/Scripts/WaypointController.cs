using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointController : MonoBehaviour
{
    public WaypointBaseController waypointBaseController;

    private void Awake()
    {
        waypointBaseController.SetTarget(GameObject.FindGameObjectWithTag("Player"));
        waypointBaseController.SetTransform(transform);
        waypointBaseController.EffeftExists(false);

        if(transform.childCount > 0)
        {
            waypointBaseController.EffeftExists(true);
            waypointBaseController.SetWayPointEffect(transform.GetChild(0).gameObject);
        }
    }


    private void FixedUpdate()
    {
        if(waypointBaseController.GetDistance(transform.position, waypointBaseController.data.item.target.transform.position) < waypointBaseController.data.interactDistance) {
            waypointBaseController.EnableWaypoint(false);
            waypointBaseController.EnableEffect(true);
        }
        else
        {
            waypointBaseController.EnableEffect(false);
            waypointBaseController.EnableWaypoint(true);
        }
    }
}
