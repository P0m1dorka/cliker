using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class RandomKey : MonoBehaviour
{
    [SerializeField] private KeyCode[] _keyArray = new KeyCode[10];
    [SerializeField] private TMP_Text _text;
    [SerializeField] private float _time;
    [SerializeField] private int _popadanie;
    [SerializeField] private int _needpopad;
    System.Random rnd = new System.Random();
    private bool _input;
    private int _random;
    private void Update()
    {
        if(_popadanie == _needpopad)
        {
            PlayerPrefs.SetInt("_passive", PlayerPrefs.GetInt("_passive") + 5);
            PlayerPrefs.SetInt("_reputation", PlayerPrefs.GetInt("_reputation") + 250);
        }
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("_needpopad") >= 15)
        {
            PlayerPrefs.SetInt("_needpopad", 15);
        }
        StartCoroutine(RandomKeyCode());
    }
    private IEnumerator RandomKeyCode()
    {
        Coroutine coroutine = null ;
        while(true)
        {
            _random = rnd.Next(0, 10);
            _text.text = $"{_keyArray[_random]}";
            coroutine = StartCoroutine(Check(_keyArray[_random]));
            yield return new WaitForSeconds(_time);
            StopCoroutine(coroutine);
            _input = false;
            _text.color = Color.white;
        }
    }
    private IEnumerator Check(KeyCode _key)
    {
        while (!_input)
        {
            if (Input.GetKeyUp(_key))
            {
                Debug.Log("Popal");
                _popadanie++;
                _text.color = Color.green;
                _input = true;

            }
            else
            {
                _text.color = Color.red;
                Debug.Log("Ne popal");
            }
            yield return new WaitForSeconds(0.0001f);
        }
            
    }
}
