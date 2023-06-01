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
    [SerializeField] private int _needreputation;
    [SerializeField] private GameObject _oldPC;
    [SerializeField] private GameObject _newPC;
    private int _scaleMoney;
    private int _maxlvl = 25;
    private int _money;
    private float cost;
    private int _lvl;
    private bool _canUp;
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
        if (PlayerPrefs.GetInt(_playerLvl) >= _maxlvl)
        {
            _costText.text = $"MAX";
            _costText.color = Color.red;
        }
        else
        {
            _costText.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)), 0)}";
            if (PlayerPrefs.GetFloat(_playerCost) > 999 && PlayerPrefs.GetFloat(_playerCost) <= 999999)
            {
                _costText.text = $"{Math.Round(PlayerPrefs.GetFloat(_playerCost) / 1000)}.{Math.Round((PlayerPrefs.GetFloat(_playerCost) % 1000) / 100)}k";
            }
            else if (PlayerPrefs.GetFloat(_playerCost) > 999999)
            {
                _costText.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_playerCost)) / 1000000)}.{Math.Round(Convert.ToDouble((PlayerPrefs.GetFloat(_playerCost)) % 1000000) / 100000)}m";
            }
        }
        _lvlText.text = $"{PlayerPrefs.GetInt(_playerLvl)}/{_maxlvl} ";
        if (PlayerPrefs.GetInt(_playerLvl) == 1)
        {
            PlayerPrefs.SetFloat(_playerCost, firstx);
        }
        if (PlayerPrefs.GetInt(_preferlvl) >= 25 && PlayerPrefs.GetInt("_reputation") >= _needreputation)
        {
            _blockImg.SetActive(false);
            _button.gameObject.SetActive(true);
        }
        else
        {
            _button.gameObject.SetActive(false);
           
        }
    }
    private void UpMo()
    {
       
           
            _blockImg.SetActive(false);
            if (PlayerPrefs.GetInt(_playerLvl) != _maxlvl)
            {
                 _blockImg.SetActive(false);
                if (PlayerPrefs.GetInt("_money") >= PlayerPrefs.GetFloat(_playerCost))
                {
                      _canUp = true;
                      StartCoroutine(ChangeColor(_canUp));
                _audio.PlayOneShot(_sound);
                _oldPC.SetActive(false);
                      _newPC.SetActive(true);
                      _money = PlayerPrefs.GetInt("_money");
                      PlayerPrefs.SetInt("_money", Convert.ToInt32(_money - PlayerPrefs.GetFloat(_playerCost)));
                      cost = (float)(((firstx * Math.Pow(1.15, Convert.ToDouble(PlayerPrefs.GetInt(_playerLvl))))));
                      PlayerPrefs.SetInt(_playerLvl, PlayerPrefs.GetInt(_playerLvl) + 1);
                      PlayerPrefs.SetFloat(_playerCost, cost);
                      PlayerPrefs.SetInt("_scaleMoney", PlayerPrefs.GetInt("_scaleMoney") + _givescale);
                      PlayerPrefs.SetInt("_reputation", PlayerPrefs.GetInt("_reputation") + _giveReputation);
                      PlayerPrefs.Save();
                }
                else
                {
                     _canUp = false;
                    StartCoroutine(ChangeColor(_canUp));
                }
            }
    }
    private IEnumerator ChangeColor(bool _can)
    {
        if (!_can)
        {
            _costText.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            _costText.color = Color.black;
        }
        else
        {
            _costText.color = Color.green;
            yield return new WaitForSeconds(0.5f);
            _costText.color = Color.black;
        }

    }
}
