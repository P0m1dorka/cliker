using System.Collections;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TargetsSPAWN : TargCheck
{
    [SerializeField] private float _coldown;
    [SerializeField] private GameObject _object;
    [SerializeField] private int maxmish;
    private int money;
    private Vector3 _posTarg; 
    private GameObject _objectTarg;
    private float x;
    private float y;
    private float z;
    private void Start()
    {
        money = PlayerPrefs.GetInt("_money");
        Debug.Log("_money");
        Debug.Log(PlayerPrefs.GetInt("_maxtargets"));
        PlayerPrefs.SetInt("_targets",0);
        maxmish = PlayerPrefs.GetInt("_maxtargets");
        if(maxmish>15)
        {
            PlayerPrefs.SetInt("_maxtargets",15);
        }
        StartCoroutine(Spawner());
    }
    private IEnumerator Spawner()
    {
       while (true)
        {
            yield return new WaitForSeconds(_coldown);
            float x = UnityEngine.Random.Range(-2f, 2f);
            float y = UnityEngine.Random.Range(0f, 2f);
            _posTarg = new Vector3(x, y, -7.8f);
            _objectTarg = Instantiate(_object, _posTarg, Quaternion.identity);
            Debug.Log(PlayerPrefs.GetInt("_targets")); 
        }
    }
    private void Update()
    { 
        money = PlayerPrefs.GetInt("_money");
        if(PlayerPrefs.GetInt("_targets") >= maxmish)
        {
            PlayerPrefs.SetInt("_reputation", PlayerPrefs.GetInt("_reputation") + 10);
            PlayerPrefs.SetInt("_maxtargets",maxmish+1);
            SceneManager.LoadScene("MainLVL");
        }
    }

}
