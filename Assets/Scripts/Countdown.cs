using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI CountDownText;
    [SerializeField] Animator _animator;
    void Start()
    {
        StartCoroutine(CountStart());
    }

    IEnumerator CountStart()
    {
        //yield return new WaitForSeconds(0.5f);
        CountDownText.text = "3";
        yield return new WaitForSeconds(1f);
        CountDownText.text = "2";
        yield return new WaitForSeconds(1f);
        CountDownText.text = "1";
        yield return new WaitForSeconds(1f);
        CountDownText.text = "GOOO";
        yield return new WaitForSeconds(0.5f);
        _animator.enabled = false;
        gameObject.SetActive(false);
    }
}
