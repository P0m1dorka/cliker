using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoseTrain : MonoBehaviour
{
    [SerializeField] private Button _butFirstTrain;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private TMP_Text _lvltext;
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private AudioClip _sound;
    [SerializeField] private string _name;
    [SerializeField] private string _cost;
    [SerializeField] private string _trainScene;
    [SerializeField] private int _firstX;
    [SerializeField] private string _lvlTrain;
    private bool _canUp;
    private float zena;
    private int   money;
    void Start()
    {
        _butFirstTrain.onClick.AddListener(ChangeScene);
        zena = PlayerPrefs.GetFloat(_cost);
    }
    private void Update()
    {   
        zena = PlayerPrefs.GetFloat(_cost);
        money = PlayerPrefs.GetInt("_money");
        _text.text = $"{Math.Round(PlayerPrefs.GetFloat(_cost))}";
        _lvltext.text = $"{PlayerPrefs.GetInt(_lvlTrain)}/{PlayerPrefs.GetInt("_lvlFmax")}";
        if (PlayerPrefs.GetFloat(_cost) > 999 && PlayerPrefs.GetFloat(_cost) <= 999999)
        {
            _text.text = $"{Math.Round(PlayerPrefs.GetFloat(_cost) / 1000)}.{Math.Round((PlayerPrefs.GetFloat(_cost) % 1000) / 100)}k";
        }
        else if (PlayerPrefs.GetFloat(_cost) > 999999)
        {
            _text.text = $"{Math.Round(Convert.ToDouble(PlayerPrefs.GetFloat(_cost)) / 1000000)}.{Math.Round(Convert.ToDouble((PlayerPrefs.GetFloat(_cost)) % 1000000) / 100000)}m";
        }
        Debug.Log($"real money = {PlayerPrefs.GetInt("_money")}");
    }
    private void ChangeScene()
    {

        if (PlayerPrefs.GetInt(_lvlTrain) >= PlayerPrefs.GetInt("_lvlFmax"))
        {

        }
        else
        {
            if (money >= zena)
            {
                _audio.PlayOneShot(_sound);
                _canUp = true;
                StartCoroutine(ChangeColor(_canUp));
                money -= Convert.ToInt32(zena);
                zena = (float)(_firstX * (Math.Pow(1.15, PlayerPrefs.GetInt(_lvlTrain)) + 1));
                PlayerPrefs.SetInt(_lvlTrain, PlayerPrefs.GetInt(_lvlTrain) + 1);
                if (PlayerPrefs.GetInt(_lvlTrain) >= PlayerPrefs.GetInt("_lvlFmax"))
                {
                    PlayerPrefs.SetInt(_lvlTrain, PlayerPrefs.GetInt(_lvlTrain) - 1);
                }
                PlayerPrefs.SetFloat(_cost, zena);
                PlayerPrefs.SetInt("_money", money);
                PlayerPrefs.SetInt("_targets", 0);
                PlayerPrefs.Save();
                SceneManager.LoadScene(_trainScene);
            }
            else
            {
                _canUp = false;
                StartCoroutine(ChangeColor(_canUp));
            }
        }
    }
    private IEnumerator ChangeColor(bool _can)
    {
        if (!_can)
        {
            _text.color = Color.red;
            yield return new WaitForSeconds(0.5f);
            _text.color = Color.black;
        }
        else
        {
            _text.color = Color.green;
            yield return new WaitForSeconds(0.5f);
            _text.color = Color.black;
        }

    }
}
