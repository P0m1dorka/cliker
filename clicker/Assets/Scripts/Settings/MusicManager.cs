using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour
{
    [SerializeField] private Slider _sliderMain;
    [SerializeField] private Slider _sliderClick;
    [SerializeField] private AudioClip _audioCclick;
    [SerializeField] private AudioSource _audioClick;
    [SerializeField] private AudioClip _audioCmain;
    [SerializeField] private AudioSource _audioMain;
    // Start is called before the first frame update
    void Start()
    {
        _sliderMain.value = PlayerPrefs.GetFloat("_mainAudio");
        _sliderClick.value = PlayerPrefs.GetFloat("_clickAudio");
    }

    // Update is called once per frame
    void Update()
    {
        _audioMain.volume = _sliderMain.value;
        _audioClick.volume = _sliderClick.value;
        PlayerPrefs.SetFloat("_clickAudio",_audioClick.volume); 
        PlayerPrefs.SetFloat("_mainAudio", _audioMain.volume);
    }
    public void PlaySound()
    {
        _audioMain.PlayOneShot(_audioCmain);
    }
}
