using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainSoundSet : MonoBehaviour
{
    [SerializeField] private Slider _sliderMain;
    [SerializeField] private AudioClip _audioCmain;
    [SerializeField] private string _music;
    // Start is called before the first frame update
    void Start()
    {
        _sliderMain.value = PlayerPrefs.GetFloat(_music);
    }
    void Update()
    {
        SaveMusic.Instance.Audio.volume = _sliderMain.value;
        PlayerPrefs.SetFloat(_music, SaveMusic.Instance.Audio.volume);
    }
    public void PlaySound()
    {
        SaveMusic.Instance.Audio.PlayOneShot(_audioCmain);
    }
}
