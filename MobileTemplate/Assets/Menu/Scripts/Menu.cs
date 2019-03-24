using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Image cover;
    public float fadeSpeed = 1;

    public void Exit()
    {
        Application.Quit();
    }

    private void Start()
    {
        if(cover != null)
        StartCoroutine(FadeIn());
    }

    public void Play()
    {
        LoadLevel(2);
    }

    public void Credits()
    {
        StartCoroutine(ToCredits());
    }

    public void OpenMenu()
    {
        LoadLevel(0);
    }

    public void LoadLevel(int id)
    {
        Application.LoadLevel(id);
    }

    IEnumerator ToCredits()
    {
        //cover.color = new Color(0,0,0,0);

        float value = 0;

        while(value < 1)
        {
            cover.color = new Color(0, 0, 0, value);
            value += fadeSpeed * Time.deltaTime;

            yield return null;
        }

        cover.color = new Color(0, 0, 0, 1);

        LoadLevel(1);
    }

    IEnumerator FadeIn()
    {
        //cover.color = new Color(0,0,0,0);

        float value = 1;

        while (value > 0)
        {
            cover.color = new Color(0, 0, 0, value);
            value -= fadeSpeed * Time.deltaTime;

            yield return null;
        }

        cover.color = new Color(0, 0, 0, 0);
        //cover.gameObject.SetActive(false);
    }



}
