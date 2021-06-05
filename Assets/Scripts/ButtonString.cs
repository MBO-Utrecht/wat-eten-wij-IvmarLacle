using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;


public class ButtonString : MonoBehaviour
{
    public TextMeshProUGUI largeText;

    public void BtnAction()
    {
        PickRandoList();
    }

    void PickRandoList()
    {
        string[] students = new string[] {"Aruban", "ChinaLatina", "Dutch", "Colombian", 
                                          "Japanese", "Mexican", "LazyCook"};
        string randomName = students[Random.Range(0, students.Length)];
        largeText.text = randomName.ToString();
    }
}
