using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResetCuisines : MonoBehaviour
{
    // Method created for resetting each day
    public void ResetSavedCuisines()
    {
        PlayerPrefs.DeleteKey("Day");
        PlayerPrefs.DeleteKey("Day1");
        PlayerPrefs.DeleteKey("Day2");
        PlayerPrefs.DeleteKey("Day3");
        PlayerPrefs.DeleteKey("Day4");
        PlayerPrefs.DeleteKey("Day5");
        PlayerPrefs.DeleteKey("Day6");
    }
}
