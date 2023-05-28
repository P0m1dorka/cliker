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
    [SerializeField] private GameObject _answerCanvas;
    private WaitForSeconds _wfs;
    private int _rep;
    private float _win_or_lose;
    private Coroutine _coroutine;
    
    private void Start()
    {
        _button.onClick.AddListener(STourment);
    }
    private void STourment()
    {
        if (PlayerPrefs.GetInt("_reputation" ) >= 100)
        {
            _coroutine = StartCoroutine(StartTourment());
        }
        else
        {
            _button.gameObject.SetActive(false);
            _answerCanvas.SetActive(true);
            new WaitForSeconds(1f);
            _answerCanvas.SetActive(false);
            _button.gameObject.SetActive(true);
            Debug.Log("tesdt");
            PlayerPrefs.SetInt("_reputation", 125);
        }
    }

    private IEnumerator StartTourment()
    {


        yield return new WaitForSeconds(_waitTime);
        Debug.Log("test");
        //Debug.Log("StartTourment");
        //    yield return new WaitForSeconds(_waitTime);
        //    _win_or_lose = Random.value;
        //Debug.Log($"do buff {_win_or_lose}");
        //    _win_or_lose += PlayerPrefs.GetFloat("_scalerep");
        //Debug.Log($"upnity {_win_or_lose}");
        //    if (_win_or_lose > 0.5f)
        //    {
        //        Debug.Log("win");
        //        _rep++;
        //        PlayerPrefs.SetInt("_reputation", _rep);
        //    }
        //    StopCoroutine(_coroutine);
        
    }
}