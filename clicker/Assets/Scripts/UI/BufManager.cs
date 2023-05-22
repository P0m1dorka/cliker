using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _trains = new GameObject[2];
    [SerializeField] private GameObject[] _bufs = new GameObject[2];
    [SerializeField] private GameObject[] _tourments = new GameObject[2];
    void Update()
    {
        if (PlayerPrefs.GetInt("_reputation") >= 5)
        {
            PlayerPrefs.SetFloat("_scalerep", 0.2f);
            _trains[0].SetActive(true);
            _bufs[0].SetActive(true);
            _tourments[0].SetActive(true);
        }
    }
}
