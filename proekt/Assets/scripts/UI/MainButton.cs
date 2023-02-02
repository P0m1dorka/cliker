using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private TMP_Text _text;
    private int coins;
    void Start()
    {
        _button.onClick.AddListener(ZachislenieMonet);
    }
    // Update is called once per frame
    void  ZachislenieMonet()
    {
        coins++;
    }
    void Update()
    {
        _text.text = $"Coins: {coins}";
    }
}
