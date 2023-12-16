using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private TraumaInducer scriptTraumaInducer;
    [SerializeField] private bool isCameraShake;
    [SerializeField] private AudioClip[] soundDestruction;
    private int floorDamage;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        scriptTraumaInducer = gameObject.GetComponent<TraumaInducer>();
    }

    public IEnumerator CameraShake()
    {
        if (!isCameraShake)
        {
            isCameraShake = true;
            yield return new WaitForSeconds(0.1f);
            
            if (floorDamage <= 25)
            {
                scriptTraumaInducer.CameraShake(0.25f);
                PlaySoundDestruction(0);
            }
            else if (floorDamage > 25 && floorDamage <= 50)
            {
                scriptTraumaInducer.CameraShake(0.5f);
                PlaySoundDestruction(1);
            }
            else if (floorDamage > 50 && floorDamage <= 100)
            {
                scriptTraumaInducer.CameraShake(0.75f);
                PlaySoundDestruction(2);
            }
            else if (floorDamage > 100 && floorDamage <= 150)
            {
                scriptTraumaInducer.CameraShake(1.0f);
                PlaySoundDestruction(3);
            }
            else if (floorDamage > 150 && floorDamage <= 200)
            {
                scriptTraumaInducer.CameraShake(1.25f);
                PlaySoundDestruction(4);
            }
            else if (floorDamage > 200 && floorDamage <= 250)
            {
                scriptTraumaInducer.CameraShake(1.5f);
                PlaySoundDestruction(5);
            }
            else if (floorDamage > 250 && floorDamage <= 300)
            {
                scriptTraumaInducer.CameraShake(1.75f);
                PlaySoundDestruction(6);
            }
            else if (floorDamage > 300)
            {
                scriptTraumaInducer.CameraShake(2.0f);
                PlaySoundDestruction(7);
            }

            yield return new WaitForSeconds(1.0f);
            isCameraShake = false;
        }
    }

    public void PlaySoundDestruction(int index)
    {
        //Debug.Log("floor damage: " + floorDamage);
        audioSource.PlayOneShot(soundDestruction[index], 2.0f);
        floorDamage = 0;

    }

    public void CountFloorDamage()
    {
        floorDamage += 1;
    }
}
