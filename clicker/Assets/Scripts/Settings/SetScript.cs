using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetScript : MonoBehaviour
{
    [SerializeField] private GameObject _closeCan;
    [SerializeField] private GameObject _openCan;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Open);
    }
    private void Open()
    {
        _closeCan.SetActive(false);
        _openCan.SetActive(true);
    }
}
