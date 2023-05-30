using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
   private KeyCode[] array = new KeyCode[5];
    private void Start()
    {
        if (PlayerPrefs.GetInt("_firstTime") == 1)
        {
            PlayerPrefs.SetInt("_money", 100);
            PlayerPrefs.SetInt("_reputation", 100);
            PlayerPrefs.SetInt("_scaleMoney", 1);
            PlayerPrefs.SetFloat("_costfirsttrain", 250);
            PlayerPrefs.SetFloat("_costFupgrade", 100);
            PlayerPrefs.SetFloat("_costMupgrade", 100);
            PlayerPrefs.SetFloat("_costHupgrade", 100);
            PlayerPrefs.SetInt("_lvlFupgrade", 0);
            PlayerPrefs.SetInt("_lvlMupgrade", 0);
            PlayerPrefs.SetInt("_lvlHupgrade", 0);
            PlayerPrefs.SetInt("_passive", 0);
        }

    }
    void Update()
    {
        if(Input.anyKeyDown)
        {
            SceneManager.LoadScene("MainLVL");
        }
    }
}
