using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UPManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _lvlText;
    [SerializeField] private TMP_Text _costText;
    [SerializeField] private Button _button;
    [SerializeField] private string _playerCost; //= "_costFupgrade"
    [SerializeField] private string _playerLvl ; //= "_lvlFupgrade"
    [SerializeField] private int _needreputation;
    [SerializeField] private GameObject _blockImg;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sound;
    private int _scaleMoney;
    private int _money;
    private float cost;
    private int _lvl;
    void Start()
    {
        PlayerPrefs.SetInt(_playerLvl, 0);
        PlayerPrefs.SetFloat(_playerCost, 20);
        _lvl = PlayerPrefs.GetInt(_playerLvl);
        cost = PlayerPrefs.GetFloat(_playerCost);
        _money = PlayerPrefs.GetInt("_money");
        _scaleMoney = PlayerPrefs.GetInt("_scaleMoney");
        _button.onClick.AddListener(UpMo);
    }
    private void Update()
    {
        _costText.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)),0)}";
        _lvlText.text = $"{PlayerPrefs.GetInt(_playerLvl)}";
        if (PlayerPrefs.GetInt("_reputation") >= _needreputation)
        {
            _blockImg.SetActive(false);

        }
        else
        {
            _blockImg.SetActive(true);
        }
    }
    private void UpMo()
    {
        if (PlayerPrefs.GetInt("_reputation") >= _needreputation)
        {
            _audio.PlayOneShot(_sound);
            _blockImg.SetActive(false);
            if (PlayerPrefs.GetInt("_money") > PlayerPrefs.GetFloat(_playerCost))
            {
                cost = PlayerPrefs.GetFloat(_playerCost);
                cost += PlayerPrefs.GetFloat(_playerCost) * 0.3f;
                _money = PlayerPrefs.GetInt("_money");
                _money -= Convert.ToInt32(PlayerPrefs.GetFloat(_playerCost));
                PlayerPrefs.SetInt("_money", _money);
                _scaleMoney = 1 + _scaleMoney;
                PlayerPrefs.SetInt("_scaleMoney", _scaleMoney);
                PlayerPrefs.SetFloat(_playerCost, cost);
                PlayerPrefs.SetInt(_playerLvl, PlayerPrefs.GetInt(_playerLvl) + 1);
                PlayerPrefs.Save();
            }
        }
        else
        {
            _blockImg.SetActive(true);
        }
       
    }

}
