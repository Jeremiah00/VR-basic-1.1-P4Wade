using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballbounce : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
