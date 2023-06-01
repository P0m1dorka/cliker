using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimBoss : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private float _maxtime;
    void Start()
    {
     
    }
    // Update is called once per frame
    void Update()
    {
        if (_maxtime <= 0)
        {
            _maxtime = 0;
        }
        else
        {
            _maxtime -= Time.deltaTime;
        }

        _text.text = $"Time: {Math.Round(_maxtime)}";
    }
}
