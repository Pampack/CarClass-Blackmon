using UnityEngine;

public class Car
{
    private int year;
    private string make;
    private float currentSpeed = 0f;
    private float maxSpeed = 100f;

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

    public void AccelerateCar()
    {
        if(currentSpeed > maxSpeed)
        {
            currentSpeed = maxSpeed;
        }
        else if(Input.GetKey(KeyCode.UpArrow))
        {
            currentSpeed = (currentSpeed * 1 * Time.deltaTime);
        }
    }

    public void DecelerateCar()
    {
        if(currentSpeed < 0)
        {
            currentSpeed = 0;
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            currentSpeed = (currentSpeed * -1 * Time.deltaTime);
        }
    }
}
