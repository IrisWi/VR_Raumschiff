﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public DoorController door;
    public string password;
    public int passwordLimit;
    //public Text passwordText;
    public TextMeshProUGUI passwordText;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip correctSound;
    public AudioClip wrongSound;

    private void Start()
    {
        passwordText.text = "";
    }

    public void PasswordEntry(string number)
    {
        if (number == "Clear")
        {
            Clear();
            return;
        }
        else if(number == "Enter")
        {
            Enter();
            return;
        }

        int length = passwordText.text.ToString().Length;
        if(length<passwordLimit)
        {
            passwordText.text = passwordText.text + number;
        }
    }

    public void Clear()
    {
        passwordText.text = "";
        passwordText.color = Color.black;
    }

    private void Enter()
    {
        if (passwordText.text == password)
        {
            //door.lockedByPassword = false;

            if (audioSource != null)
                audioSource.PlayOneShot(correctSound);

            passwordText.color = Color.green;
            SceneManager.LoadScene("Flur", LoadSceneMode.Single);
            //StartCoroutine(waitAndClear());
        }
        else
        {
            if (audioSource != null)
                audioSource.PlayOneShot(wrongSound);

            passwordText.color = Color.red;
            StartCoroutine(waitAndClear());
        }
    }

    IEnumerator waitAndClear()
    {
        yield return new WaitForSeconds(0.75f);
        Clear();
    }


}
