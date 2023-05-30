using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseScript : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private GameObject _mainCanvas;
    [SerializeField] private GameObject _closeCanvas;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sound;
    void Start()
    {
        _closeButton.onClick.AddListener(Close);
    }
    private void Close()
    {
        _audio.PlayOneShot(_sound); 
        _mainCanvas.SetActive(true);
        _closeCanvas.SetActive(false);
    }
}
