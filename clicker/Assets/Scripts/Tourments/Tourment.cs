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
    private void Start()
    {
        _rep = PlayerPrefs.GetInt("_reputation");
    }
    private IEnumerator StartTourment()
    {
        while (true)
        {
            Debug.Log("StartTourment");
            yield return new WaitForSeconds(_waitTime);
            _win_or_lose = Random.value;
            if (_win_or_lose > 0.5f)
            {
                PlayerPrefs.SetInt("_reputation", _rep++);
            }
        }
    }
}