using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Assertions.Must;
using System.Threading;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class AudioRob2 : MonoBehaviour
{

    public Image imgCircle;
    public UnityEvent GVRClick;
    public float totalTime = 2;
    bool gvrStatus;
    public float gvrTimer;

    bool timeroff = false;
    // Update is called once per frame
    void Update()
    {

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgCircle.fillAmount = gvrTimer / totalTime;
        }

        if (gvrTimer > totalTime)
        {
            if (timeroff == false)
            {
                timeroff = true;
                GVRClick.Invoke();
                gvrTimer = 0;
            }
            timeroff = false;
        }
    }

    public void hey()
    {
        UnityEngine.Debug.Log("Hey");
    }
        
    

}

