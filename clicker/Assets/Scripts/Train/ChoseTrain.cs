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
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sound;
    
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
        if (PlayerPrefs.GetFloat("_costfirsttrain") > 999 && PlayerPrefs.GetFloat("_costfirsttrain") <= 999999)
        {
            _text.text = $"{Math.Round(PlayerPrefs.GetFloat("_costfirsttrain") / 1000)}.{Math.Round((PlayerPrefs.GetFloat("_costfirsttrain") % 1000) / 100)}k";
        }
        else if (PlayerPrefs.GetFloat("_costfirsttrain") > 999999)
        {
            _text.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat("_costfirsttrain")) / 1000000)}.{Math.Round(Convert.ToDouble((PlayerPrefs.GetFloat("_costfirsttrain")) % 1000000) / 100000)}m";
        }
        Debug.Log($"real money = {PlayerPrefs.GetInt("_money")}");
    }
    private void ChangeScene()
    {
        if(money>=zena)
        {
            _audio.PlayOneShot(_sound);
            money -= Convert.ToInt32(zena);
            zena += PlayerPrefs.GetFloat("_costfirsttrain") * 0.3f;
            PlayerPrefs.SetFloat("_costfirsttrain", zena);
            PlayerPrefs.SetInt("_money", money);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Train1");
        }
    }
}
