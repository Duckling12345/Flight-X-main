using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWaypointController : CameraWaypointBaseController
{
    private void FixedUpdate()
    {
            if(data.waypoints != null && data.waypoints.Count > 0)
        {
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        foreach(WaypointController waypoint in data.waypoints)
        {
            waypoint.waypointBaseController.data.item.image.transform.position = UIImagePosition(waypoint.waypointBaseController.data.item);
            waypoint.waypointBaseController.data.item.message.text = WaypointDistance(waypoint.waypointBaseController.data.item) + "M";     
        }
    }
}
