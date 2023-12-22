using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneCloud : MonoBehaviour
{
    [SerializeField] private Animator animatorMeat;
    [SerializeField] private ParticleSystem[] particleBlood;

    public void TurnTheHunkeyDoreyNoLongerIntoABoneCloud()
    {
        animatorMeat.SetBool("isBumpBump", true);

        for (int i = 0; i < particleBlood.Length; i++)
        {
            particleBlood[i].Play();
        }
    }
}
