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
        
        PlayerPrefs.Save();
        _money = PlayerPrefs.GetInt("_money");
        _moneyText.text = $"Score: {_money}";
        _repText.text = $"Reputation : {PlayerPrefs.GetInt("_reputation")}";
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
        _ray = _maincam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(_ray, out RaycastHit raycastHit))
        {
            _objectPopUp = Instantiate(_popUpPrefab, raycastHit.point, Quaternion.identity,transform);
       //     _objectPopUp.transform.position = raycastHit.point;
        }
    }
    private void OnMouseDown()
    {
        PlusMoney();
    }
}
