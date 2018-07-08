using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ClockAnimation : MonoBehaviour {
    public TimeSpan TimeOfDay;
    public Transform hourTransform, minuteTransform, secondTransform;
    private float degreesInHour, degreesInMinute, degreesInSecond;
    public bool analog;
    private float time_f = 0f;

    // Use this for initialization
    void Start () {
        degreesInHour = 360 / 12;     // rotate 360/12 in hour.
        degreesInMinute = 360 / 60;    // rotate 360/60 in minute.
        degreesInSecond = 360 / 60;    // rotate 360/60 in second.

    }

    // Update is called once per frame
    void Update () {
        if (analog)
        {
            time_f -= Time.deltaTime;
            TimeOfDay = new TimeSpan(16,00,00);
            hourTransform.localRotation = Quaternion.Euler(0f, 0f, 240+((time_f /60)/48)*15* +degreesInHour);
            minuteTransform.localRotation = Quaternion.Euler(0f, 0f, (time_f/60)*15 * +degreesInMinute);
            secondTransform.localRotation = Quaternion.Euler(0f, 0f, time_f*15 * +degreesInSecond);
        }
        else
        {
            DateTime time = DateTime.Now;
            hourTransform.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -degreesInHour);
            minuteTransform.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -degreesInMinute);
            secondTransform.localRotation = Quaternion.Euler(0f, 0f, time.Second * -degreesInSecond);
        }
    }
}
