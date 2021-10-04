using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableQuestionMark : MonoBehaviour
{
    [SerializeField] private GameObject checkMark;
    [SerializeField] private GameObject checkMark2;



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            checkMark.SetActive(false);
            checkMark2.SetActive(false);
        }
    }
}
