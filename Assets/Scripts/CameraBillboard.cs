using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraBillboard : MonoBehaviour
{

    public CinemachineVirtualCamera m_Camera;
    private void LateUpdate()
    {
        transform.LookAt(transform.position + m_Camera.transform.rotation * Vector3.forward,
        m_Camera.transform.rotation * Vector3.up);
    }
}