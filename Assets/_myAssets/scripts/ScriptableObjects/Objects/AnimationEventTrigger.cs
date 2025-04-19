using UnityEngine;
using System.Collections;

public class AnimationEventTrigger : MonoBehaviour
{
    public AudioSource src;
    public AudioClip clip;
    public float min = .9f;
    public float max = 1.2f;

    public Transform dustRight;
    public Transform dustLeft;

    void Start ()
    {
       dustRight.GetComponent<ParticleSystem>().enableEmission = false;
       dustLeft.GetComponent<ParticleSystem>().enableEmission = false;

       /* ParticleSystem ps = dustRight.GetComponent<ParticleSystem>();
        var em = ps.emission;
        em.enabled = false;
        ps.Play();

        ParticleSystem ps2 = dustLeft.GetComponent<ParticleSystem>();
        var em2 = ps2.emission;
        em2.enabled = false;
        ps2.Play(); */

    }


    public void playFootstepLeft()
    {
        src.clip = clip;
        src.pitch = Random.Range(min, max);
        src.Play();
         dustLeft.GetComponent<ParticleSystem>().enableEmission = true;
        //em2.enabled = true;
        print("Left Foot");
    }

    public void footDustPauseLeft()
    {

        dustLeft.GetComponent<ParticleSystem>().enableEmission = false;
    }


    public void playFootstepRight()
    {
        src.clip = clip;
        src.pitch = Random.Range(min, max);
        src.Play();
        dustRight.GetComponent<ParticleSystem>().enableEmission = true;
        print("Right Foot");


    }

    public void footDustPauseRight()
    {

        dustRight.GetComponent<ParticleSystem>().enableEmission = false;
    }


}
