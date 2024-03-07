using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighter : MonoBehaviour


{
    public ParticleSystem ParticleSystem;
    // Start is called before the first frame update
    void Awake()
    {
        ParticleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
