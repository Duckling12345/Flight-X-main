using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;


public class LoadingBar : MonoBehaviour
{
    
    public GameObject LoadBar;
    public int time;
    
    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateBar() {
        LeanTween.scaleX(LoadBar, 1, time);
    }
}
