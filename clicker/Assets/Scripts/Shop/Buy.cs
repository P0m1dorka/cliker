using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(BuyAlmaz);
    }

    private void BuyAlmaz()
    {
        if (PlayerPrefs.GetInt("_reputation") >= 100)
        {
            PlayerPrefs.SetInt("_reputation", 0);
            PlayerPrefs.SetInt("_almazi", 100);
        }
    }
}
