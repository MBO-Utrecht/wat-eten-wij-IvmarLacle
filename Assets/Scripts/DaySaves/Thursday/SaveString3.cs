using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveString3 : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI saveText;
    
    void Start()
    {
        saveText.text = PlayerPrefs.GetString("Day3");
    }
}
