using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
using Timer = System.Timers.Timer;

public class antichit : MonoBehaviour
{
    [SerializeField] private Button _button;
    private DateTime dt = new DateTime();
    private int _cliks;
    private int _cliksMaxAmoiunt = 17;
    private bool ban = false;
    
    void Start()
    {
        _button.onClick.AddListener(Zachislenie);
        StartCoroutine(CheckClick());


    }

    void Zachislenie()
    {
        _cliks++;
    }

    private IEnumerator CheckClick()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            if (_cliks > _cliksMaxAmoiunt)
            {
                ban = true;
                
            }
            else
            {
                ban = false;
            }

            _cliks = 0;
        }
    }
    


}
