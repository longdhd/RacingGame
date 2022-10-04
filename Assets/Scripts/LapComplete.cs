using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LapComplete : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI BestMinuteText;
    [SerializeField] TextMeshProUGUI BestSecondText;
    [SerializeField] TextMeshProUGUI BestMiliText;

    public GameObject HalfLapTrigger;

    private void OnTriggerEnter()
    {
        if(LapTimeManager.SecondCount <= 9)
        {
            BestSecondText.text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            BestSecondText.text = LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            BestMinuteText.text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            BestMinuteText.text = LapTimeManager.MinuteCount + ".";
        }

        BestMiliText.text = "" + LapTimeManager.MiliCount.ToString("F0");

        LapTimeManager.MiliCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MinuteCount = 0;

        HalfLapTrigger.SetActive(true);
        gameObject.SetActive(false);
    }
}
