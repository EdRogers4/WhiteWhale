using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEvents : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private EventManager scriptEventManager;

    public void PlayHeartBeat()
    {
        scriptEventManager.PlayHeartBeat();
    }
}
