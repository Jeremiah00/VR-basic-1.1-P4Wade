using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightitup : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particle;
    public GameObject gameOb;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == gameOb)
        {
            particle.Play();
        }
    }
}

