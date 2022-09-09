using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaitBeforeAttackingAgain : MonoBehaviour
{
    public int waitTime;
    private int fadeTime;

    private Text waitText;

    private RawImage fadeImg;
    private bool canFade;
    private GameObject waitBeforeAttackPanel;

    private void Awake()
    {
        waitBeforeAttackPanel = transform.GetChild(0).gameObject;
        waitText = waitBeforeAttackPanel.GetComponentInChildren<Text>();
        waitText.text = waitTime.ToString();
        fadeImg = waitBeforeAttackPanel.GetComponent<RawImage>();
        fadeTime = waitTime;
        waitBeforeAttackPanel.SetActive(false);
    }
    private void Update()
    {

    }
    public void ActivateFadeOut()
    {
        waitBeforeAttackPanel.SetActive(true);
        waitText.text = waitTime.ToString();
        Color temp = fadeImg.color;
        temp.a = 1f;
        fadeImg.color = temp;
        StartCoroutine(CountDown());
    }

    void FadeOut()
    {
        if (canFade)
        {
            Color temp = fadeImg.color;
            temp.a -= (Time.deltaTime / fadeTime) / 2f;
            fadeImg.color = temp;
        }
    }
    IEnumerator CountDown()
    {
        canFade = true;
        yield return new WaitForSeconds(1);
        waitTime -= 1;
        if (waitTime != -1)
        {
            waitText.text = waitTime.ToString();
            StartCoroutine(CountDown());
        }
        else
        {
            waitTime = fadeTime;
            waitBeforeAttackPanel.SetActive(false);
        }
    }
}
