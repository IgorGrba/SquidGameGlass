using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLineParticles : MonoBehaviour
{
    [SerializeField] private GameObject endParticles;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            endParticles.SetActive(true);
        }
    }
}
