using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Tourment : MonoBehaviour
{
    [SerializeField] private float _waitTime;
    [SerializeField] private Button _button;
    private WaitForSeconds _wfs;
    private int _rep;
    private float _win_or_lose;
    private Coroutine _coroutine;
    
    private void Start()
    {
        _rep = PlayerPrefs.GetInt("_reputation");
        _button.onClick.AddListener(STourment);
    }

    private void STourment()
    {
        if (PlayerPrefs.GetInt("_money" ) >= 100)
        {
            PlayerPrefs.SetInt("_money", (PlayerPrefs.GetInt("_money") - 100));
            _coroutine = StartCoroutine(StartTourment());
        }
    }

    private IEnumerator StartTourment()
    {
       
            Debug.Log("StartTourment");
            yield return new WaitForSeconds(_waitTime);
            _win_or_lose = Random.value;
            if (_win_or_lose > 0.5f)
            {
                PlayerPrefs.SetInt("_reputation", _rep++);
            }
            StopCoroutine(_coroutine);
        
    }
}