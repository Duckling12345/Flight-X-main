using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;


public class LoadingBar : MonoBehaviour
{
    
    public GameObject LoadBar0;
    public GameObject LoadBar1;
    public GameObject LoadBar2;
    public GameObject LoadBar3;

    public int time;
    
    void Start()
    {
        AnimateBar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimateBar()
{
    LeanTween.scaleX(LoadBar0, 1, time);
    LeanTween.scaleX(LoadBar1, 1, time);
    LeanTween.scaleX(LoadBar2, 1, time);
    LeanTween.scaleX(LoadBar3, 1, time);
}

}
