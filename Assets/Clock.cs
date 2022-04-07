using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    //The transforms of the hour, minute and second hands
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    // Start is called before the first frame update
    void Start()
    {
        //Get the transforms of the hour and minute hands
        hourHand = transform.Find("Clock_Analog_A_Hour");
        minuteHand = transform.Find("Clock_Analog_A_Minute");
        secondHand = transform.Find("Clock_Analog_A_Second");
    }

    // Update is called once per frame
    void Update()
    {
        //Get the system's current time
        System.DateTime currentTime = System.DateTime.Now;

        //apply the rotation to the hour hand
        hourHand.localRotation = Quaternion.Euler(currentTime.Hour * 30f, 0f, 0f);

        //apply the rotation to the minute hand
        minuteHand.localRotation = Quaternion.Euler(currentTime.Minute * 6f, 0f, 0f);

        //apply the rotation to the second hand via the pivot
        secondHand.localRotation = Quaternion.Euler(currentTime.Second * 6f, 0f, 0f);
    }
}
