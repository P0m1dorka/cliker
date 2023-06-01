using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    private const int _needrep = 4000;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Buy);    
    }
    private void Buy()
    {
        if (PlayerPrefs.GetInt("_reputation") >= _needrep)
        {
            PlayerPrefs.SetInt("_almazi",50);
        }
        else
        {
            StartCoroutine(ReColor());
        }
    }

    private IEnumerator ReColor()
    {
        _text.color = Color.red;
        yield return new WaitForSeconds(1f);
        _text.color = Color.black;
    }
}
