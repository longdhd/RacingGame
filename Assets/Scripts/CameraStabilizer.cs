using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStabilizer : MonoBehaviour
{
    public GameObject _car;
    public float _carX;
    public float _carY;
    public float _carZ;
    void Update()
    {
        _carX = _car.transform.eulerAngles.x;
        _carY = _car.transform.eulerAngles.y;
        _carZ = _car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(_carX - _carX, _carY, _carZ - _carZ);
    }
}
