using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFX : MonoBehaviour
{
    public static SoundFX instantiate;

    AudioSource audioSource;
    public AudioClip[] hitAudio;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        instantiate = this;
    }

    public void Hit()
    {
        int hit = Random.Range(0, hitAudio.Length);
        audioSource.PlayOneShot(hitAudio[hit]);
    }
}
