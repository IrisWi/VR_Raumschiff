﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Assertions.Must;
using System.Threading;
using UnityEngine.SceneManagement;

public class InteractionScript1 : MonoBehaviour

{
   
    public Image imgCircle;
    public UnityEvent interaction;
    public float totalTime = 2;
    bool status;
    public float timer;
    public AudioSource audio;
    public AudioSource audio2;


    bool timeroff = false;


    // Update is called once per frame
    void Update()
    {

        if (status)
        {
            timer += Time.deltaTime;
            imgCircle.fillAmount = timer / totalTime;
        }

        if (timer > totalTime)
        {
            if (timeroff == false)
            {
                timeroff = true;
                interaction.Invoke();
                timer = 0;
            }
            timeroff = false;
        }

    }

    public void InteractioOn()
    {
        status = true;
    }

    public void InteractionOff()
    {
        status = false;
        timer = 0;
        imgCircle.fillAmount = 0;
    }

    public void derReiheNach()
    {
        audio.Play();
        Invoke("spieleDasRaetsel", 17);
    }

    void spieleDasRaetsel()
    {
        audio2.Play();
    }


}