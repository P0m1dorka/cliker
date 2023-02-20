using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private Button _button4lvlup;
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Button _shariki;
    public int coins;
    private int f = 1;
    private int st = 10;
    void Start()
    {
        _button.onClick.AddListener(ZachislenieMonet);
        _button4lvlup.onClick.AddListener(lvlup);
        _shariki.onClick.AddListener(shariki);
    }
    // Update is called once per frame
    void lvlup()
    {
        if (coins >= st)
        {
            f++;
            coins = coins - st;
            st = st * 10;
        }
        
    }

    void shariki()
    {
        if (coins >= 30)
        {
            SceneManager.LoadScene(2);
            coins = coins - 30;
        }
    }
    void  ZachislenieMonet()
    {
        coins = coins + f ;
    }
    void Update()
    {
        _text.text = $"Coins: {coins}";
    }
}
