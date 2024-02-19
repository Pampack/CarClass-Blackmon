using System.IO;
using UnityEngine;

public class Car
{
    private int year;
    private string make;
    private float currentSpeed = 0f;
    private float maxSpeed = 100f;
    private float accelerationSpeed = 4.0f;

    public string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }

    public float Speed
    {
        get
        {
            return currentSpeed;
        }
    }

    public void AccelerateCar()
    {
        if(currentSpeed < maxSpeed)
        {
            currentSpeed = currentSpeed + accelerationSpeed * Time.deltaTime;
        }
    }

    public void DecelerateCar()
    {
        if(currentSpeed > 0.0f)
        {
            currentSpeed = currentSpeed - accelerationSpeed * Time.deltaTime;
        }

    }
}
