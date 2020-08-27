using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;

public class StartAudioAfterAudio : MonoBehaviour
{

    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Play", 15);
       
    }

    // Update is called once per frame
    void Update()
    {
     
        
        
    }

    void Play()
    {
        audioSource.Play();
    }

  
}
