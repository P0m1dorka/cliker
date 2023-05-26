using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseTrain : MonoBehaviour
{
    [SerializeField] private Button _butFirstTrain;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Text _moneyText;
    private float zena;
    private int   money;
    void Start()
    {
        _butFirstTrain.onClick.AddListener(ChangeScene);
        zena = PlayerPrefs.GetFloat("_costfirsttrain");
        Debug.Log($"CostTrain: {PlayerPrefs.GetInt("_costfirsttrain")}");
    }

    private void Update()
    {
   
        zena = PlayerPrefs.GetFloat("_costfirsttrain");
        money = PlayerPrefs.GetInt("_money");
        _text.text = $"{PlayerPrefs.GetFloat("_costfirsttrain")}";
//        _moneyText.text = $"Score: {PlayerPrefs.GetInt("_money")}";
        Debug.Log($"real money = {PlayerPrefs.GetInt("_money")}");
    }

    private void ChangeScene()
    {
        if(money>=zena)
        {
            money -= Convert.ToInt32(zena);
            zena += Convert.ToInt32(zena * 0.2);
            Debug.Log($"after = {Convert.ToInt32(zena*0.2)}");
            PlayerPrefs.SetFloat("_costfirsttrain", zena);
            PlayerPrefs.SetInt("_money", money);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Train1");
        }
    }
}
