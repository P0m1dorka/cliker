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
        _rep = 0;   
        
        _rep = PlayerPrefs.GetInt("_reputation");
        _button.onClick.AddListener(STourment);
    }

    private void STourment()
    {
        _coroutine = StartCoroutine(StartTourment());
    }

    private IEnumerator StartTourment()
    {
             yield return new WaitForSeconds(_waitTime);
            _win_or_lose = Random.value;
            if (_win_or_lose > 0.5f)
            {
                PlayerPrefs.SetInt("_reputation", _rep++);
                StopCoroutine(_coroutine);
            }
            StopCoroutine(_coroutine);
    }
}