using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseTrain : MonoBehaviour
{
    [SerializeField] private Button _butFirstTrain;
   
    private double _costtrain;
    void Start()
    { 
        Debug.Log("chisto");
         _butFirstTrain.onClick.AddListener(ChangeScene);
         Debug.Log(PlayerPrefs.GetInt("_costfirsttrain"));
    }
    private void ChangeScene()
    {
        Debug.Log("Test");
        if(PlayerPrefs.GetInt("_money")>=PlayerPrefs.GetInt("_costfirsttrain"))
        {
            _costtrain += _costtrain * 0.2;
            PlayerPrefs.SetInt("_costfirsttrain", Convert.ToInt32(_costtrain));
            PlayerPrefs.SetInt("_money",PlayerPrefs.GetInt("_money")-10);
            SceneManager.LoadScene("Train1");
        }
    }
}
