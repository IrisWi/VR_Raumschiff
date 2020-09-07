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

public class InteractionScript : MonoBehaviour
{
   
    public Image imgCircle;
    public UnityEvent interactionEvent;
    public float totalTime = 2;
    bool status;
    public float timer;
    public AudioSource audio;
    public AudioSource audio2;
    public Animatortext dasScript;
    public Text Text2;

    bool timeroff = false;

    void Start()
  {
       dasScript = GameObject.FindGameObjectWithTag("Text3").GetComponent<Animatortext>();
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
                interactionEvent.Invoke();
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
        dasScript.Moin();
        UnityEngine.Debug.Log("Hey");
        audio.Play();
        Invoke("spieleDasRaetsel", 17);
    }

    void spieleDasRaetsel()
    {
        audio2.Play();
    }


}