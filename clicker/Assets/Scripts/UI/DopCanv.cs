using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DopCanv : MonoBehaviour
{
    [SerializeField] private GameObject _mainCanvas;
    [SerializeField] private GameObject _trainCanvas;
    [SerializeField] private GameObject _tourmentCanvas;
    [SerializeField] private GameObject _upgradeCanvas;
    [SerializeField] private GameObject _storeCanvas;
    [SerializeField] private Button _upbutton;
    [SerializeField] private Button _storeButton;
    [SerializeField] private Button _trainbutton;
    [SerializeField] private Button _tourbutton;
    void Start()
    {
        _upbutton.onClick.AddListener(UPBut);    
        _trainbutton.onClick.AddListener(TrainBut);
        _tourbutton.onClick.AddListener(TourBut);
        _storeButton.onClick.AddListener(STBut);
    }
    private void TourBut()
    {
       _mainCanvas.SetActive(false);
        _tourmentCanvas.SetActive(true);

    }
    private void TrainBut()
    {
        _mainCanvas.SetActive(false);
        _trainCanvas.SetActive(true);
    }

    private void UPBut()
    {
        _mainCanvas.SetActive(false);
        _upgradeCanvas.SetActive(true);
    }
    private void STBut()
    {
        _mainCanvas.SetActive(false);
        _storeCanvas.SetActive(true);
    }
}
