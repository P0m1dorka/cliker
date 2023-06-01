using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class Tourment : MonoBehaviour
{
    [SerializeField] private float _waitTime;
    [SerializeField] private Button _button;
    [SerializeField] private string _scene;
    [SerializeField] private int _needRep;
    [SerializeField] private GameObject _blockIMG;
    private Coroutine _coroutine;
    private void Start()
    {
        _button.onClick.AddListener(STourment);
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("_reputation") >= _needRep)
        {
            _blockIMG.SetActive(false);
        }
    }
    private void STourment()
    {
        if (PlayerPrefs.GetInt("_reputation" ) >= _needRep)
        {
            SceneManager.LoadScene(_scene);
        }
        else
        {
    
        }
    }
}