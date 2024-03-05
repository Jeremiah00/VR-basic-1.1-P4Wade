using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightitup : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particle;
    public GameObject gameOb;
    public bool lit;

    private void Awake()
    {
        particle.Stop();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == gameOb)
        {
            lit = true;
            if (lit)
            {
                particle.Play();
            }
            else
            {
                particle.Stop();
            }
        }
    }
}

