using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour
{
    [SerializeField] private Slider _sliderMain;
    [SerializeField] private AudioClip _audioCmain;
    [SerializeField] private AudioSource _audioMain;
    [SerializeField] private string _music;
    // Start is called before the first frame update
    void Start()
    {
        _sliderMain.value = PlayerPrefs.GetFloat(_music);
    }
   
    void Update()
    {
        _audioMain.volume = _sliderMain.value;
        PlayerPrefs.SetFloat(_music, _audioMain.volume);
    }
    public void PlaySound()
    {
        _audioMain.PlayOneShot(_audioCmain);
    }
}
