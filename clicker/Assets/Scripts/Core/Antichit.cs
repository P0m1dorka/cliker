using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Antichit : MonoBehaviour
{
    private int _clicks = 0;
    private bool _chit;
    [SerializeField] private int _maxClicks;
    
    void Start()
    {
        StartCoroutine(Check());
    }
    private void Update()
    {
        Debug.Log($"clicks = {_clicks}");
        if (Input.GetMouseButtonDown(0))
        {
            _clicks++;
        }
    }

    private IEnumerator Check()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            if(_clicks >= _maxClicks)
            {
                _chit = true;
                _clicks = 0;
                PlayerPrefs.SetInt("_firstTime", 1);
                SceneManager.LoadScene("StartScene");
            }
            else
            {
                PlayerPrefs.SetInt("_firstTime", 0);
                _clicks = 0;
            }
        }
    }
}
