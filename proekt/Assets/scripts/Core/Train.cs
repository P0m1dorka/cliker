using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Train : MonoBehaviour
{
    [SerializeField] private Button[] _button;
    [SerializeField] private TMP_Text _text;
    public int _lvl;
    public int x;
    private float _time;
    [SerializeField] private float _maxtime = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        _time = _maxtime;
        Method();
    }
    void Update()
    {
        _text.text = ($"pivo: {_lvl}");
        if (_time > 0)
        {
            _time -= Time.deltaTime;
        }
        else
        {
            _button[x].gameObject.SetActive(false);
            _time = _maxtime;
            Method();
        }
    }
    void Method()
    {
        x = Random.Range(0, 8);
        for (int i = 0; i < _button.Length; i++)
        {
            _button[i].gameObject.SetActive(false);
        }
        _button[x].gameObject.SetActive(true);
        _button[x].onClick.AddListener(Zachislenie);
    }
    void Zachislenie()
    {
        _lvl++;
        _button[x].gameObject.SetActive(false);
        _time = _maxtime;
        Method();
    }
    
}
