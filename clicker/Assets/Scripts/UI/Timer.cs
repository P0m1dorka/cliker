using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _maxTime;
    [SerializeField] private string _exitScene;
    [SerializeField] private TMP_Text _text;
    void Update()
    {
        _text.text = $"Time: {Math.Round((double)_maxTime)}";
        _maxTime -= Time.deltaTime;
        if(_maxTime <= 0)
        {
            SceneManager.LoadScene(_exitScene);
        }
    }
}
