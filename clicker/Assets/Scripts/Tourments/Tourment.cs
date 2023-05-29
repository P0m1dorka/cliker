using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Tourment : MonoBehaviour
{
    [SerializeField] private float _waitTime;
    [SerializeField] private Button _button;
    [SerializeField] private GameObject _answerCanvas;
    private Coroutine _coroutine;
    
    private void Start()
    {
        _button.onClick.AddListener(STourment);
    }
    private void STourment()
    {
        if (PlayerPrefs.GetInt("_reputation" ) >= 100)
        {
            //  _coroutine = StartCoroutine(StartTourment());
            SceneManager.LoadScene("SanyaSimple");
        }
        else
        {
            _coroutine = StartCoroutine(NoTourment());
        }
    }

    private IEnumerator NoTourment()
    {

        Debug.Log("test1");
        _answerCanvas.SetActive(true);
        yield return new WaitForSeconds(2f);
        _answerCanvas.SetActive(false);
        Debug.Log("dOBE");
        StopCoroutine(_coroutine);
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