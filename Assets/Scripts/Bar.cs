using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class Bar : MonoBehaviour
{
    public GameObject Bar0;
    public GameObject Bar1;
    public GameObject Bar2;
    public GameObject Bar3;
    public int time;

    void OnEnable()
    {
        AnimateBars();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnimateBars()
    {
        LeanTween.scaleX(Bar0, 1, time);
        LeanTween.scaleX(Bar1, 1, time);
        LeanTween.scaleX(Bar2, 1, time);
        LeanTween.scaleX(Bar3, 1, time);
    }
}
