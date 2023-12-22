using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSoundClipStation : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioSource audioSourceMusic;
    [SerializeField] private AudioClip[] soundDoo;
    [SerializeField] private AudioClip[] soundRocksOnTheGround;
    [SerializeField] private AudioClip theSong;
    [SerializeField] private AudioClip soundHeartbeat;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSourceMusic.PlayOneShot(theSong, 20.0f);
    }

    public void PlayHeartBeat()
    {
        audioSource.PlayOneShot(soundHeartbeat, 25.0f);
    }

    public void PlayTheSoundOfTheFloorGoingBoom(int index)
    {
        audioSource.PlayOneShot(soundDoo[index], 6.0f);
        audioSource.PlayOneShot(soundRocksOnTheGround[index], 6.0f);
    }
}
