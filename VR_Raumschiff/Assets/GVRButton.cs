using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Assertions.Must;
using System.Threading;
using UnityEngine.SceneManagement;

public class GVRButton : MonoBehaviour
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

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgCircle.fillAmount = 0;
    }

    public void SceneToCodePad()
    {
        SceneManager.LoadScene("CodepadScene", LoadSceneMode.Single);
    }

    public void SceneToKeyBoard()
    {
        SceneManager.LoadScene("KeyboardScene", LoadSceneMode.Single);
    }

    public void SceneToSteuerbord()
    {
        SceneManager.LoadScene("Steuerbord", LoadSceneMode.Single);
    }
    public void SceneToFlur()
    {
        SceneManager.LoadScene("Flur", LoadSceneMode.Single);
    }
    public void SceneToAbstellkammer()
    {
        SceneManager.LoadScene("Steuerbord", LoadSceneMode.Single);
    }
    public void SceneToSchlafraum()
    {
        SceneManager.LoadScene("Schlafraum", LoadSceneMode.Single);
    }
    public void SceneToWeltall()
    {
        SceneManager.LoadScene("Schlafraum", LoadSceneMode.Single);
    }
}
