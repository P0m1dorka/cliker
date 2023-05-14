using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DopCanv : MonoBehaviour
{
    [SerializeField] private Button _upbutton;
    [SerializeField] private GameObject _upobject;
    [SerializeField] private Button _trainbutton;
    [SerializeField] private GameObject _trainobject;
    [SerializeField] private Button _tourbutton;
    [SerializeField] private GameObject _tourobject;
    void Start()
    {
        _upbutton.onClick.AddListener(UPBut);    
        _trainbutton.onClick.AddListener(TrainBut);
        _tourbutton.onClick.AddListener(TourBut);
    }
    private void TourBut()
    {
        _trainobject.SetActive(false);
        _upobject.SetActive(false);
        _tourobject.SetActive(true);

    }
    private void TrainBut()
    {
        _trainobject.SetActive(true);
        _upobject.SetActive(false);
        _tourobject.SetActive(false);
    }

    private void UPBut()
    {
        _trainobject.SetActive(false);
        _upobject.SetActive(true);
        _tourobject.SetActive(false);
    }
}
