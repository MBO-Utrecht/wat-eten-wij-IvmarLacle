using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfterClickSave5 : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI afterText;
    
    public void BtnSave()
    {
        PlayerPrefs.SetString("Day5", afterText.text);
    }
}
