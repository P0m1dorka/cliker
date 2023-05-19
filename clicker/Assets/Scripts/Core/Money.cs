using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private int _money;
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private GameObject _popUpPrefab;
    private int scale;
    private GameObject _POPuP;
    // Start is called before the first frame update
    void Start()
    {
        scale = PlayerPrefs.GetInt("_scaleMoney");
        _money = PlayerPrefs.GetInt("_money") + 10;
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
        PopUP();
    }
    private void PopUP()
    {
        Vector3 _camerapos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        _camerapos.z = -7f;
        _POPuP = Instantiate(_popUpPrefab, _camerapos,Quaternion.identity);
    }

    private void OnMouseDown()
    {
        PlusMoney();
        PopUP();
    }
}
