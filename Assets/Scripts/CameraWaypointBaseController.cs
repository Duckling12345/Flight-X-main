using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraWaypointBaseController : MonoBehaviour
{
    [System.Serializable]

    public struct WaypointData
    {
        public GameObject worldWaypoints;
        public List<WaypointController> waypoints;
        [HideInInspector] public int screenWidth;
        [HideInInspector] public int screenHeight;
        [HideInInspector] public Camera fpsCam;
    }

    public WaypointData data;

    public void Start()
    {
        data.fpsCam = Camera.main;
        data.screenWidth = Screen.width;
        data.screenHeight = Screen.height;

        if(data.worldWaypoints.transform.childCount > 0)
        {
            for(int i = 0; i < data.worldWaypoints.transform.childCount; i++ )
            {
                WaypointController tmpWayPointController = data.worldWaypoints.transform.GetChild(i).GetComponent<WaypointController>();

                if(tmpWayPointController != null)
                {
                    data.waypoints.Add(tmpWayPointController);
                }
            }
        }
    }

    public Vector2 UIImagePosition(WayPointItem item)
    {
        float itemImageWidth = item.image.GetPixelAdjustedRect().width / 2;
        float itemImageHeight = item.image.GetPixelAdjustedRect().height / 2;

        Vector2 screenPosition = GetItemScreenPosition(item);
        screenPosition.x = ScreenClapm(screenPosition.x, itemImageWidth, data.screenWidth);
        screenPosition.y = ScreenClapm(screenPosition.y, itemImageHeight, data.screenHeight);

        return screenPosition;
    }

    public float WaypointDistance(WayPointItem item)
    {
        return Mathf.Round(Vector3.Distance(item.transform.position, transform.position));
    }

    public float ScreenClapm(float screenPosition, float itemImageWidth, int screenWidth)
    {
        return Mathf.Clamp(screenPosition, itemImageWidth, screenWidth - itemImageWidth);
    }

    public Vector2 GetItemScreenPosition(WayPointItem item)
    {
        float x = item.transform.position.x;
        float y = item.transform.position.y;
        float z = item.transform.position.z;
        Vector2 screenPosition = data.fpsCam.WorldToScreenPoint(new Vector3(x, y, z));

        if(Vector3.Dot((item.transform.position - transform.position), transform.forward) < 0)
        {
            if(screenPosition.x < Screen.width / 2)
            {
                screenPosition.x = Screen.width - item.image.GetPixelAdjustedRect().width/2;
            }else
            {
                screenPosition.x = item.image.GetPixelAdjustedRect().width / 2;
            }
            if (screenPosition.y < Screen.height / 2)
            {
                screenPosition.y = Screen.height - item.image.GetPixelAdjustedRect().height / 2;
            }
            else
            {
                screenPosition.y = item.image.GetPixelAdjustedRect().height/2;
            }
        }
        return screenPosition;
    }
}

