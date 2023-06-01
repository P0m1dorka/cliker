using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour
{
    [SerializeField] private Image _healhBar;
    [SerializeField] private float _damage;
    [SerializeField] private float _healtAmount;
    [SerializeField] private int _klicks;
    [SerializeField] private float _maxtime;
    private int _rep;
    private void Start()
    {
        _klicks = 0;
        _rep = PlayerPrefs.GetInt("_reputation");
    }
    void Update()
    {
        _maxtime -= Time.deltaTime;
        if(_maxtime < 0) 
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (_healtAmount <= 0)
        {
            _rep += 1000;
            PlayerPrefs.SetInt("_reputation", _rep);
            SceneManager.LoadScene("MainLVL");
        }
    }
    private void OnMouseDown()
    {
        _klicks++;
        _healtAmount -= _damage;
        _healhBar.fillAmount = _healtAmount / 100f;
    }
    
}
