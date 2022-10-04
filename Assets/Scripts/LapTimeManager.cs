using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LapTimeManager : MonoBehaviour
{
    public static int MinuteCount = 0;
    public static int SecondCount = 0;
    public static float MiliCount = 0;
    public static string MiliDisplay;

    [SerializeField] TextMeshProUGUI MinuteText;
    [SerializeField] TextMeshProUGUI SecondText;
    [SerializeField] TextMeshProUGUI MiliText;


    // Update is called once per frame
    void Update()
    {
        MiliCount += Time.deltaTime * 10;
        MiliDisplay = MiliCount.ToString("F0");
        MiliText.text = "" + MiliDisplay;

        if(MiliCount >=10)
        {
            MiliCount = 0;
            SecondCount += 1;
        }

        if(SecondCount <= 9)
        {
            SecondText.text = "0" + SecondCount + ".";
        }
        else
        {
            SecondText.text = SecondCount + ".";
        }

        if(SecondCount >= 60)
        {
            SecondCount = 0;
            MinuteCount += 1;
        }

        if (MinuteCount <= 9)
        {
            MinuteText.text = "0" + MinuteCount + ":";
        }
        else
        {
            MinuteText.text = MinuteCount + ":";
        }


    }
}
