using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveINCOME : MonoBehaviour
{
    [SerializeField] private WaitForSeconds wait;
    private int money;
    private int passiv;
    void Start()
    {
        wait = new WaitForSeconds(1f);
        StartCoroutine(Passive());
    }
    private IEnumerator Passive()
    {
      while (true)
        {
            yield return wait;
            passiv = PlayerPrefs.GetInt("_passive");
            money = PlayerPrefs.GetInt("_money");
            PlayerPrefs.SetInt("_money", money + passiv);
        }
    }
}
