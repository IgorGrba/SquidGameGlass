using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayer1 : MonoBehaviour
{
    [SerializeField] private GameObject fakePlayer;
    [SerializeField] private GameObject realPlayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            fakePlayer.SetActive(false);
            realPlayer.SetActive(true);
        }
    }
}
