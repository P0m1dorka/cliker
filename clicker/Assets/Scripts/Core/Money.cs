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
    // Start is called before the first frame update
    void Start()
    {
        _moneyButton.onClick.AddListener(PlusMoney);   
    }
    private void Update()
    {
        PlayerPrefs.SetInt("money", _money);
        _moneyText.text = $"Score: {_money}";
    }
    private void PlusMoney()
    {
        _money += 1 ;
    }
}
