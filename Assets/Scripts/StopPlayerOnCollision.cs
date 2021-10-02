using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StopPlayerOnCollision : MonoBehaviour
{
    public NavMeshAgent navMeshAgent1;
    public NavMeshAgent navMeshAgent2;
    public NavMeshAgent navMeshAgent3;
    public NavMeshAgent navMeshAgent4;



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player1")
        {
            navMeshAgent1.speed = 0.5f;
        }
        else if (other.gameObject.tag == "Player2")
        {
            navMeshAgent2.speed = 0.5f;
        }
        else if (other.gameObject.tag == "Player3")
        {
            navMeshAgent3.speed = 0.5f;
        }
        else if (other.gameObject.tag == "Player4")
        {
            navMeshAgent4.speed = 0.5f;
        }
    }
}
