using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("_money", 100);
        PlayerPrefs.SetInt("_reputation", 99);
        PlayerPrefs.SetInt("_scaleMoney",1);
        PlayerPrefs.SetFloat("_costfirsttrain",230);
        PlayerPrefs.SetFloat("_costupgrade",100);
        PlayerPrefs.SetInt("_passive",0);
    }
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainLVL");
        }
    }
}
