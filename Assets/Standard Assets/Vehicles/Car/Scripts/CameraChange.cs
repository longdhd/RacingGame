using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    [SerializeField] GameObject _camOne;
    [SerializeField] GameObject _camTwo;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Viewmode"))
        {
            _camOne.SetActive(false);
            _camTwo.SetActive(true);
        }
        else
        {
            _camOne.SetActive(true);
            _camTwo.SetActive(false);
        }
    }
}
