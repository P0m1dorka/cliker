using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Match : MonoBehaviour
{
    [SerializeField] private Image _healhBar;
    [SerializeField] private float _damage;
    [SerializeField] private float _healtAmount;
    [SerializeField] private int _klicks;
    [SerializeField] public float _maxtime;
    [SerializeField] private string _nameTur;
    [SerializeField] private GameObject _lose;
    [SerializeField] private GameObject _lose2;
    [SerializeField] private AudioSource _audioSettings;
    [SerializeField] private AudioClip _sound;
    private int _rep;
    private void Start()
    {
        _klicks = 0;
        _lose.SetActive(false);
        _lose2.SetActive(true);

    }
    void Update()
    {
        _maxtime -= Time.deltaTime;
        if(_maxtime < 0) 
        {   
            _lose2.SetActive(false);
            _lose.SetActive(true);
            StartCoroutine(Retry());
            
        }
        if (_healtAmount <= 0)
        {
            PlayerPrefs.SetInt(_nameTur, 1);    
            SceneManager.LoadScene("MainLVL");
        }
    }

    private IEnumerator Retry()
    {
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnMouseDown()
    {
        _audioSettings.PlayOneShot(_sound);
        _klicks++;
        _healtAmount -= _damage;
        _healhBar.fillAmount = _healtAmount / 100f;
    }
    
}
