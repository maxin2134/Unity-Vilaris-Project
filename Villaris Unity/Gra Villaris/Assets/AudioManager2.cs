using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Diagnostics;

public class AudioManager2 : MonoBehaviour
{
    public Sounds[] sounds;

    public static AudioManager2 instance;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
        
        foreach (Sounds s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start ()
    {
        Play("Theme");
    }
    
    public void Play(string name)
    {
        Sounds s = Array.Find(sounds, sounds => sounds.name == name);
        s.source.Play();
        if (s == null)
        {
         }
        s.source.Play();
    }
}
