using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveINCOME : MonoBehaviour
{
    [SerializeField] private WaitForSeconds wait;
    private int money;
    void Start()
    {
       // PlayerPrefs.SetInt("_money", 0);
       // PlayerPrefs.SetInt("_scaleMoney", 1);
        StartCoroutine(Passive());
    }

    private IEnumerator Passive()
    {
      while (true)
        {
            yield return new WaitForSeconds(1);
            PlayerPrefs.SetInt("_money", PlayerPrefs.GetInt("_money") + 1);
        }
    }
}
