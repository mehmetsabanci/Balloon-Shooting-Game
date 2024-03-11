using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SesKontrol : MonoBehaviour
{
    public AudioClip BalloonExplosion;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

   public void BalonSound()
    {
        audioSource.clip = BalloonExplosion;
        audioSource.Play();
    }
}
