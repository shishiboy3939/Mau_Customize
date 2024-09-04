using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager: MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] public AudioClip SE_Hit;
    [SerializeField] public AudioSource SeSource;

    
   private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void PlaySoundEffect(AudioClip sound) {
        SeSource.PlayOneShot(sound);
    }
}
