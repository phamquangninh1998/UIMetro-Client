using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{


    public float checkInternetTime;
    public Transform noInternetPopup;


    public bool internetConnected;
    [EditorButton]
    public void IsShowUILogin(bool isShow)
    {
        if (isShow)
        {
            UILogin.Show();
        }
        else
        {
            UILogin.Hide();
        }
    }


    public void Start()
    {
        StartCheckingInternet();
    }
    private void StartCheckingInternet()
    {
        StartCoroutine(DOCheckInternet());
    }



    IEnumerator DOCheckInternet()
    {
        while (true)
        {
            if (InternetConnected())
            {
                UILogin.Instance.gameObject.SetActive(true);
                noInternetPopup.gameObject.SetActive(false);

            }
            else
            {
                UILogin.Instance.gameObject.SetActive(false);

                noInternetPopup.gameObject.SetActive(true);
            }

            yield return new WaitForSeconds(checkInternetTime);
        }
    }

    bool InternetConnected()
    {
        return internetConnected;
    }
}