using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerParticles2 : MonoBehaviour
{
    [SerializeField] private GameObject glow1;
    [SerializeField] private GameObject glow2;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            glow1.SetActive(false);
            glow2.SetActive(true);
        }
    }
}
