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
        PlayerPrefs.SetInt("_firstTime", 1);
        if (PlayerPrefs.GetInt("_firstTime") == 1)
        {
            PlayerPrefs.SetInt("_money", 100);
            PlayerPrefs.SetInt("_reputation", 100);
            PlayerPrefs.SetInt("_scaleMoney", 1);
            PlayerPrefs.SetFloat("_costfirsttrain", 2500000);
            PlayerPrefs.SetFloat("_costFupgrade", 100);
            PlayerPrefs.SetFloat("_costMupgrade", 3500);
            PlayerPrefs.SetFloat("_costHupgrade", 125000);
            PlayerPrefs.SetInt("_lvlFtrain", 1);
            PlayerPrefs.SetInt("_lvlFmax", 10);
            PlayerPrefs.SetInt("_lvlStrain", 1);
            PlayerPrefs.SetInt("_lvlSmax", 10);
            PlayerPrefs.SetFloat("_costFtrain", 115);
            PlayerPrefs.SetFloat("_costStrain", 5000);
            PlayerPrefs.SetInt("_lvl0upgrade", 25);
            PlayerPrefs.SetInt("_lvlFupgrade", 1);
            PlayerPrefs.SetInt("_maxtargets", 5);
            PlayerPrefs.SetInt("_targets", 0);
            PlayerPrefs.SetInt("_needpopad", 10);
            PlayerPrefs.SetInt("_lvlMupgrade", 1);
            PlayerPrefs.SetInt("_lvlHupgrade", 1);
            PlayerPrefs.SetInt("_passive", 0);
            PlayerPrefs.SetInt("_almazi", 10);
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
