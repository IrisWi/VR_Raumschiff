using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartAudioAfterAudio : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioSource audioSource2;
    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("Play", 14);
       
    }

    // Update is called once per frame
    void Update()
    {
     
        
        
    }

    void Play()
    {
        audioSource.Play();
        //      waitForSeconds(audioSource.)
        Invoke("PlaySecond", 17);
    }

    void PlaySecond()
    {
        audioSource2.Play();
        Invoke("ChangeScene", 5);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Steuerbord", LoadSceneMode.Single);
    }
  
}
