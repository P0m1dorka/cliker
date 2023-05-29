using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Match : MonoBehaviour
{
    [SerializeField] private int _klicks;
    [SerializeField] private int _maxkilcks;
    [SerializeField] private float _maxtime;
    private int _rep;
    private void Start()
    {
        _rep = PlayerPrefs.GetInt("_reputation");
    }
    void Update()
    {
        _maxtime -= Time.deltaTime;
        if(_maxtime < 0) 
        {
            Debug.Log("Lose");
            SceneManager.LoadScene("MainLVL");
        }
        else if (_klicks >= _maxkilcks)
        {
            _rep += 1000;
            PlayerPrefs.SetInt("_reputation", _rep);
            Debug.Log("WIN");
            SceneManager.LoadScene("MainLVL");
        }
    }
    private void OnMouseDown()
    {
        Debug.Log("Pivo");
        _klicks++;
    }
}
