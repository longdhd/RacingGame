using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapTrigger : MonoBehaviour
{
    public GameObject fullLap;

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            fullLap.SetActive(true);
        }
    }
}
