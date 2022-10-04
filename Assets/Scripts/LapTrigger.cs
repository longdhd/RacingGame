using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger : MonoBehaviour
{
    public GameObject fullLap;

    private void OnTriggerEnter()
    {
        gameObject.SetActive(false);
        fullLap.SetActive(true);
    }
}
