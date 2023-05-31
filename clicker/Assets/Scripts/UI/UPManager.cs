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
    [SerializeField] private string _playerLvl; //= "_lvlFupgrade"
    [SerializeField] private string _preferlvl;
    [SerializeField] private int _prefer;
    [SerializeField] private int firstx;
    [SerializeField] private int _giveReputation;
    [SerializeField] private GameObject _blockImg;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sound;
    [SerializeField] private int _givescale;
    private int _scaleMoney;
    private int _maxlvl = 25;
    private int _money;
    private float cost;
    private int _lvl;
    void Start()
    {
        _prefer = PlayerPrefs.GetInt(_preferlvl);
        _lvl = PlayerPrefs.GetInt(_playerLvl);
         cost = PlayerPrefs.GetFloat(_playerCost);
        _money = PlayerPrefs.GetInt("_money");
        _scaleMoney = PlayerPrefs.GetInt("_scaleMoney");
        _button.onClick.AddListener(UpMo);
    }
    private void Update()
    {
        _costText.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)),0)}";
        if (PlayerPrefs.GetFloat(_playerCost)>999 && PlayerPrefs.GetFloat(_playerCost) <= 999999)
        {
          //  _costText.text = $"{PlayerPrefs.GetFloat(_playerCost)/1000}.{}k";
            _costText.text = $"{Math.Round(PlayerPrefs.GetFloat(_playerCost) / 1000)}.{Math.Round((PlayerPrefs.GetFloat(_playerCost) % 1000) / 100)}k";
        }
        else if (PlayerPrefs.GetFloat(_playerCost) > 999999)
        {
            Debug.Log("lyamchik");
            //  _costText.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)) / 1000000, 0)}.{(Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)) % 1000000) / 100000, 0)}m";
            _costText.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)) / 1000000)}.{Math.Round(Convert.ToDouble((PlayerPrefs.GetFloat(_playerCost)) % 1000000) / 100000)}m";
        }
        _lvlText.text = $"{PlayerPrefs.GetInt(_playerLvl)} / {_maxlvl} ";
        if (PlayerPrefs.GetInt(_playerLvl) == 1)
        {
            PlayerPrefs.SetFloat(_playerCost, firstx);
        }
        if (PlayerPrefs.GetInt(_preferlvl) >= 25)
        {
            _button.gameObject.SetActive(true);
        }
        else
        {
            _button.gameObject.SetActive(false);
            _blockImg.SetActive(true);
        }
    }
    private void UpMo()
    {
            _audio.PlayOneShot(_sound);
            _blockImg.SetActive(false);
            if (PlayerPrefs.GetInt(_playerLvl) != _maxlvl)
            {
                if (PlayerPrefs.GetInt("_money") >= PlayerPrefs.GetFloat(_playerCost))
                {
                    _money = PlayerPrefs.GetInt("_money");
                    PlayerPrefs.SetInt("_money", Convert.ToInt32(_money - PlayerPrefs.GetFloat(_playerCost)));
                    cost = (float)(((firstx * Math.Pow(1.15, Convert.ToDouble(PlayerPrefs.GetInt(_playerLvl))))));
                    PlayerPrefs.SetInt(_playerLvl, PlayerPrefs.GetInt(_playerLvl) + 1);
                    PlayerPrefs.SetFloat(_playerCost, cost);
                    PlayerPrefs.SetInt("_scaleMoney", PlayerPrefs.GetInt("_scaleMoney") + _givescale);
                    PlayerPrefs.SetInt("_reputation", PlayerPrefs.GetInt("_reputation") + _giveReputation);
                    PlayerPrefs.Save();
                }
            }
           
    }
}
