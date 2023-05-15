using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Pivo");
            _clicks++;
            Debug.Log(_clicks);
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
                // спросить у јндре€ можно ли обнулить статус игрока
                Application.Quit();
            }
            else
            {
                _clicks = 0;
            }
        }
    }
}
