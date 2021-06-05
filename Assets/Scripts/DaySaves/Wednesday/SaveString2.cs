using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveString2 : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI saveText;
    
    void Start()
    {
        saveText.text = PlayerPrefs.GetString("Day2");
    }
}
