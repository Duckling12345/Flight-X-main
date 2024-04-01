using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[System.Serializable]
public class WaypointBaseController
{
    [System.Serializable]

    public struct Data
    {
        public WayPointItem item;
        public float interactDistance;
        public bool weHaveEffects;

    }

    public Data data;
    public void  SetTarget(GameObject target) => data.item.target = target;
    public void SetTransform(Transform transform) => data.item.transform = transform;
    public void SetWayPointEffect(GameObject effect) => data.item.effect = effect;
    public void EffeftExists(bool value) => data.weHaveEffects = value;
    public float GetDistance(Vector3 startPosition, Vector3 endPosition) => Vector3.Distance(startPosition, endPosition);

    public void EnableEffect(bool value)
    {
        if(data.weHaveEffects == true)
        {
            data.item.effect.SetActive(value);
        }
    }
    
    public void EnableWaypoint (bool value)
    {
        data.item.image.enabled = value;
        data.item.message.enabled = value;
    }

}
