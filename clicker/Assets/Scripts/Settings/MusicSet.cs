using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSet : MonoBehaviour
{
    [SerializeField] private AudioSource _mainSound;
    [SerializeField] private AudioSource _clickSound;
    void Start()
    {
        _mainSound.volume = PlayerPrefs.GetFloat("_mainAudio");
        _clickSound.volume = PlayerPrefs.GetFloat("_clickAudio");
    }
}
