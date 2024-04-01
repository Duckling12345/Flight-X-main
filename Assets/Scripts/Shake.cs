using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public GameOverManager timer;
    public float shakeDuration = 0.2f;
    public float shakeIntensity = 0.1f;

    private Vector3 initialPosition;
    private float currentShakeDuration = 0f;

    //add indicator that in 30 second mark intensity + .2
    //figure out how to make the shake continous rather than on press only;
    // on sit remove shake/disable shake;

    // if sitbutton.pressed == true then shake set inactive;

    void Start()
    {
        initialPosition = transform.localPosition;   
    }


    void Update()
    {
        if(currentShakeDuration > 0)
        {
            Vector3 randomOffset = Random.insideUnitSphere * shakeIntensity;
            transform.localPosition = initialPosition + randomOffset;
            currentShakeDuration -= Time.deltaTime;

        }
        else
        {
            transform.localPosition = initialPosition;  
        }
    }

    public void ShakeScreen()
    {
        Debug.Log("gagi nagshake ata");
        currentShakeDuration = shakeDuration;
    }
}
