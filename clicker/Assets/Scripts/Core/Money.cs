using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private GameObject _popUpPrefab;
    [SerializeField] private Camera _maincam;
    [SerializeField] private TMP_Text _repText;
    [SerializeField] private AudioSource _sound;
    [SerializeField] private AudioClip _soundClick;
    private int scale;
    private Ray _ray;
    private GameObject _objectPopUp;
    private int _money;
    void Start()
    {
        scale = PlayerPrefs.GetInt("_scaleMoney");
        _money = PlayerPrefs.GetInt("_money");
        Debug.Log($"money = {_money}");
    }
    private void Update()
    {
        _money = PlayerPrefs.GetInt("_money");
        _moneyText.text = $"{PlayerPrefs.GetInt("_money")}";
        if (_money > 999 && _money<=999999)
        {
            _moneyText.text = $"{_money/1000}.{(_money%1000)/100}k";
        }
        else if (_money > 999999)
        {
            Debug.Log("lyamchik");
            _moneyText.text = $"{_money/1000000}.{(_money%1000000)/100000}m";
        }
       
        _repText.text = $"{PlayerPrefs.GetInt("_reputation")}";
    }
    private void PlusMoney()
    {
        scale = PlayerPrefs.GetInt("_scaleMoney");
        _money += 1 * scale;
        PlayerPrefs.SetInt("_money", _money);
        PopUP();
    }
    private void PopUP()
    {
        _sound.PlayOneShot(_soundClick);
        _ray = _maincam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out RaycastHit raycastHit))
        {
            _objectPopUp = Instantiate(_popUpPrefab, raycastHit.point, Quaternion.identity,transform);
            _objectPopUp.transform.Rotate(0, 19.77f, 0);
        }
    }
    private void OnMouseDown()
    {
        PlusMoney();
    }
}
