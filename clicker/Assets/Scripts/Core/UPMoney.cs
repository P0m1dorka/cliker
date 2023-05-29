using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UPMoney : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _text;
    private int _scaleMoney;
    private int _money;
    private float cost;
    void Start()
    {
        cost = PlayerPrefs.GetFloat("_costupgrade");
        _money = PlayerPrefs.GetInt("_money");
        _scaleMoney = PlayerPrefs.GetInt("_scaleMoney");
        _button.onClick.AddListener(UpMo);
    }
    private void Update()
    {
        _text.text = $"Cost: {PlayerPrefs.GetFloat("_costupgrade")}";
    }
    private void UpMo()
    {
        if (PlayerPrefs.GetInt("_money") > PlayerPrefs.GetFloat("_costupgrade"))
        {
            cost = PlayerPrefs.GetFloat("_costupgrade");
            cost += PlayerPrefs.GetFloat("_costupgrade") * 0.3f;
            _money = PlayerPrefs.GetInt("_money");
            _money -= Convert.ToInt32(PlayerPrefs.GetFloat("_costupgrade"));
            PlayerPrefs.SetInt("_money", _money);
            _scaleMoney = 1 + _scaleMoney;
            PlayerPrefs.SetInt("_scaleMoney", _scaleMoney);
            PlayerPrefs.SetFloat("_costupgrade", cost);
            PlayerPrefs.Save();
        }
    }
}
