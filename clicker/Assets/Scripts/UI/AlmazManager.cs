using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AlmazManager : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<TMP_Text>().text = $"{PlayerPrefs.GetInt("_almazi")}";
    }
}
