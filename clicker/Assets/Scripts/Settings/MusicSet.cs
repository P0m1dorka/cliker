using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicSet : MonoBehaviour
{
    [SerializeField] private AudioSource _clickSound;
    [SerializeField] private AudioSource _buySound;
    [SerializeField] private AudioSource _openSound;
    [SerializeField] private AudioSource _closeSound;
    void Start()
    {
        SaveMusic.Instance.Audio.volume = PlayerPrefs.GetFloat("_mainAudio");
        _clickSound.volume = PlayerPrefs.GetFloat("_clickAudio");
        _buySound.volume = PlayerPrefs.GetFloat("_buyAudio");
        _openSound.volume = PlayerPrefs.GetFloat("_openAudio");
        _closeSound.volume = PlayerPrefs.GetFloat("_closeAudio");
    }
}
