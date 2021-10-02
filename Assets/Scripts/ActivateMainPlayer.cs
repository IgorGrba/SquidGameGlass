using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMainPlayer : MonoBehaviour
{
    [SerializeField] private GameObject mainPlayerReal;
    [SerializeField] private GameObject fakeMainPlayer;
    [SerializeField] private GameObject startGlow;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fakeMainPlayer.SetActive(false);
            mainPlayerReal.SetActive(true);
            startGlow.SetActive(true);
        }
    }
}
