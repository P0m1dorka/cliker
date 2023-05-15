using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private int _money;
    [SerializeField] private Button _moneyButton;
    [SerializeField] private TMP_Text _moneyText;
    private int scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = PlayerPrefs.GetInt("_scaleMoney");
        _money = PlayerPrefs.GetInt("_money") + 10;
        _moneyButton.onClick.AddListener(PlusMoney);   
    }
    private void Update()
    {
        _money = PlayerPrefs.GetInt("_money");
        _moneyText.text = $"Score: {PlayerPrefs.GetInt("_money")}";
    }
    private void PlusMoney()
    {
        scale = PlayerPrefs.GetInt("_scaleMoney");
        _money += 1 * scale;
        PlayerPrefs.SetInt("_money", _money);
    }
}
