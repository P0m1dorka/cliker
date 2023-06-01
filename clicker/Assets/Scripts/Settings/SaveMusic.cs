using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveMusic : MonoBehaviour
{
    [SerializeField] private AudioSource _audio;
    private static SaveMusic _instance;
    public static SaveMusic Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }

            // Do not modify _instance here. It will be assigned in awake
            return new GameObject("(singleton) SaveMusic").AddComponent<SaveMusic>();
        }
    }
    public AudioSource Audio => _audio;
    void Awake()
    {
        // Only one instance of SoundManager at a time!
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
