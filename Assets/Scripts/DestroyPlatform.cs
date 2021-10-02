using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class DestroyPlatform : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator myAnim;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            navMeshAgent.enabled = false;
        }
        else if (other.gameObject.tag == "GoodPlatform")
        {
            myAnim.SetTrigger("Idle");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "StartPlatform")
        {
            myAnim.SetTrigger("Idle");
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "StartPlatform")
        {
            myAnim.SetTrigger("Run");
        }
    }
}
