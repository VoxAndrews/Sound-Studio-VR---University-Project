using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickEffects : MonoBehaviour
{
    [SerializeField]
    ParticleSystem impactEffect;

    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Interactable":
                Debug.Log("Playing Particle Effect");

                impactEffect.Play();

                break;
        }
    }
}
