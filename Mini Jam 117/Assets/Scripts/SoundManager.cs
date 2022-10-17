using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private AudioClip[] audioClips;
    [SerializeField] private AudioSource audioSrc;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySoundClip(int i)
    {
        audioSrc.PlayOneShot(audioClips[i]);
    }
}
