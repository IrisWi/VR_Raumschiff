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

public class ToEndScene : MonoBehaviour
{

    public Image imgCircle;
    public UnityEvent interactionEvent;
    public float totalTime = 2;
    bool status;
    public float timer;
    public AudioSource schnarchen;
    public AudioSource ups;
    public Animatortext dasScript;
    public Text Text2;

    bool timeroff = false;

    void Start()
    {
        //dasScript = GameObject.FindGameObjectWithTag("Text3").GetComponent<Animatortext>();
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
        //dasScript.Moin();
        UnityEngine.Debug.Log("Hey");
        ups.Play();
        schnarchen.Stop();
        Invoke("ChangeScene", 5);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Finale", LoadSceneMode.Single);
    }

}