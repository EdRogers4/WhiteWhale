using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEvents : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private TheSoundClipStation scriptSoundClip;

    public void PlayHeartBeat()
    {
        scriptSoundClip.PlayHeartBeat();
    }
}
