using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScreenAudio : MonoBehaviour
{
    public AudioSource endingAudio;

    // Start is called before the first frame update
    void Start()
    {
        endingAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
