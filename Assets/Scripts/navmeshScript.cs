using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navmeshScript : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Camera playerCamera;

    [SerializeField] private Animator charAnim;

    [SerializeField] private Rigidbody myRB;


    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        myRB = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray myRay = playerCamera.ScreenPointToRay(Input.mousePosition);

            RaycastHit myRaycastHit;

            if (Physics.Raycast(myRay, out myRaycastHit))
            {
                navMeshAgent.SetDestination(myRaycastHit.point);
            }
        }
    }
}
