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
    public static float LapTimer = 0;
    public static float BestTimer = 0;

    [SerializeField] TextMeshProUGUI MinuteText;
    [SerializeField] TextMeshProUGUI SecondText;
    [SerializeField] TextMeshProUGUI MiliText;
    bool hasStarted = false;


    private void Start()
    {
        StartCoroutine(StartLapTimer());
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted)
        {
            MiliCount += Time.deltaTime * 10;
            LapTimer += Time.deltaTime;
        }
        MiliDisplay = MiliCount.ToString("F0");
        MiliText.text = "" + MiliDisplay;

        if (MiliCount >= 10)
        {
            MiliCount = 0;
            SecondCount += 1;
        }

        if (SecondCount <= 9)
        {
            SecondText.text = "0" + SecondCount + ".";
        }
        else
        {
            SecondText.text = SecondCount + ".";
        }

        if (SecondCount >= 60)
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

    IEnumerator StartLapTimer()
    {
        yield return new WaitForSeconds(3f);
        hasStarted = true;
    }
}
