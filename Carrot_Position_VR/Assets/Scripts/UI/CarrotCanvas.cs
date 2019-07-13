using System;
using UnityEngine;
using UnityEngine.UI;

public class CarrotCanvas : MonoBehaviour
{
    [SerializeField] private InputField carrotInputField;
    [SerializeField] private Button setCarrotPositionButton;

    private void Awake()
    {
        carrotInputField.text = "Hello World";
    }
}