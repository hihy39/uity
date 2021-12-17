using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfx : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip audioClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("Collect_Item_Bling_3");
    }

    public static void SoundPlay()
    {
        audioSource.PlayOneShot(audioClip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
