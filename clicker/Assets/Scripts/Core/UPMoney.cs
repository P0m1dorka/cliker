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
    // Start is called before the first frame update
    void Start()
    {
        _scaleMoney = PlayerPrefs.GetInt("_scaleMoney");
        _button.onClick.AddListener(UpMo);
    }
    private void Update()
    {
        _text.text = "Cost: 10";
    }
    private void UpMo()
    {
        Debug.Log("test");
        if (PlayerPrefs.GetInt("_money") > 10)
        {
            PlayerPrefs.SetInt("_money", PlayerPrefs.GetInt("_money") - 10);
            _scaleMoney = 1 + _scaleMoney;
            PlayerPrefs.SetInt("_scaleMoney", _scaleMoney);
            Debug.Log(_scaleMoney);
        }
    }
}
