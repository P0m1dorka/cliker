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
    [SerializeField] private string _scene;
    [SerializeField] private int _needRep;
    private Coroutine _coroutine;
    private void Start()
    {
        _button.onClick.AddListener(STourment);
    }
    private void STourment()
    {
        if (PlayerPrefs.GetInt("_reputation" ) >= _needRep)
        {
            SceneManager.LoadScene(_scene);
        }
        else
        {
            _coroutine = StartCoroutine(NoTourment());
        }
    }

    private IEnumerator NoTourment()
    {
        _answerCanvas.SetActive(true);
        yield return new WaitForSeconds(2f);
        _answerCanvas.SetActive(false);
        StopCoroutine(_coroutine);
    }
}