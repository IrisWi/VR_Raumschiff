using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Assertions.Must;
using System.Threading;
using UnityEngine.SceneManagement;

    public class Next : MonoBehaviour
{
    public Image imgCircle;
    public UnityEvent hey;
    public float totalTime = 2;
    bool status;
    public float timer;
    public AudioSource audio;
    public AudioSource audio2;
    public Animatortext dasScript;

    bool timeroff = false;
   
    void Start()
    {
        dasScript = GameObject.FindGameObjectWithTag("Text2").GetComponent<Animatortext>();
    }

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
                hey.Invoke();
                timer = 0;
            }
            timeroff = false;
        }
       // EventTrigger trigger = GetComponentInParent<EventTrigger>();
        //EventTrigger.Entry entry = new EventTrigger.Entry();
        //entry.eventID = EventTriggerType.Select;
        //entry.callback.AddListener((eventData) => { Foo(); });
    }

    public void NextOn()
    {
        status = true;
    }

    public void NextOff()
    {
        status = false;
        timer = 0;
        imgCircle.fillAmount = 0;
    }

    public void derReiheNach()
    {
        dasScript.Moin();
        audio.Play();
        Invoke("spieleDasRaetsel", 14);
    }

    void spieleDasRaetsel()
    {
        audio2.Play();
    }


}
