using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour {

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    // Start is called before the first frame update
    

    // private void Awake()
    //{
    //    TimeSpan time = DateTime.Now.TimeOfDay;
    //    hoursPivot.localRotation = Quaternion.Euler ( 0f, 0f,(float)time.TotalHours * hoursToDegrees);
    //    minutesPivot.localRotation = Quaternion.Euler(0f, 0f,(float)time.TotalMinutes * minutesToDegrees);
    //    secondsPivot.localRotation = Quaternion.Euler (0f, 0f,(float)time.TotalSeconds * secondsToDegrees);
    //}


    // Update is called once per frame
    void Update()
    {
        // Debug.Log(DateTime.Now);
        // hoursPivot.localRotation = Quaternion.Euler(0, 0, -30 * DateTime.Now.Hour);
        // minutesPivot.localRotation = Quaternion.Euler(0, 0, -30 * DateTime.Now.Hour);
        //secondsPivot.localRotation = Quaternion.Euler(0, 0, -6 * DateTime.Now.Minute);

        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalHours * hoursToDegrees);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalMinutes * minutesToDegrees);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, (float)time.TotalSeconds * secondsToDegrees);
    }
}
