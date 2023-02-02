using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class antichit : MonoBehaviour
{
    [SerializeField] private Button _button;
    private DateTime dt = new DateTime();
    private int _cliks;
    private int time;
    void Start()
    {
        _button.onClick.AddListener(Zachisle);
    }
    void Zachisle()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _cliks++;
        }
    }
        
    void Update()
    {
        

        for (int i = 1; i >= 0; i--)
        {
            if (_cliks > 15)
            {
                Debug.Log("читер");
            }
            else
            {
             Debug.Log("всё норм");   
            }
            
        }
    }
}
