using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ShowUIScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);

    }

    void OnMouseUp()
    {
        SceneManager.LoadScene("CodepadScene", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.SetActive(true);
    }

    private void ShowPanel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //if (passwordText.text == password)
        //{
        //    //door.lockedByPassword = false;
        //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //    //StartCoroutine(waitAndClear());
        //}
        //else
        //{
        //    StartCoroutine(waitAndClear());
        //}
    }
}