using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private TMP_Text errorText;
    [SerializeField] private TMP_Text carText;
    [SerializeField] private TMP_InputField yearInput;
    [SerializeField] private TMP_InputField makeInput;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private TMP_Text speedText;
    Car newCar;

    public void OnCreateButtonClick()
    {
        if (makeInput.text == "")
        {
            errorText.text = "Please enter a make for the car.";
        }
        else if (yearInput.text == "")
        {
            errorText.text = "Please enter a year for the car.";
        }
        else if (int.Parse(yearInput.text) < 1886 || int.Parse(yearInput.text) > 2024)
        {
            errorText.text = "Please enter a year between 1886 and 2024 for the car.";
        }
        else
        {
            startPanel.SetActive(false);
            newCar = new Car();
            newCar.Make = makeInput.text;
            newCar.Year = int.Parse(yearInput.text);
            carText.text = $"Current Car: {newCar.Year} {newCar.Make}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newCar.AccelerateCar();
            speedText.text = $"Current Speed: {newCar.Speed}/100";
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            newCar.DecelerateCar();
            speedText.text = $"Current Speed: {newCar.Speed}/100";
        }
    }
}
