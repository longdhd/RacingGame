using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWaypoint : MonoBehaviour
{
    [SerializeField] GameObject AICar;
    [SerializeField] GameObject _target;
    [SerializeField] GameObject[] waypoints;
    public int currentWP = 0;

    // Start is called before the first frame update
    void Update()
    {
        _target.transform.position = waypoints[currentWP].transform.position;
    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AICar"))
            {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            currentWP += 1;
            if (currentWP == waypoints.Length)
            {
                currentWP = 0;
            }
            yield return new WaitForSeconds(1f);
            gameObject.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
