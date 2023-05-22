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
        PlayerPrefs.SetInt("_money", 0);
        PlayerPrefs.SetInt("_reputation", 4);
        PlayerPrefs.SetInt("_scaleMoney",1);
        PlayerPrefs.SetFloat("_costfirsttrain",10);
        PlayerPrefs.SetFloat("_scalerep",0.1f);
        PlayerPrefs.SetInt("_passive",1);
    }
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainLVL");
        }
    }

}
