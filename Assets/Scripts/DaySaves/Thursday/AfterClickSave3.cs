using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfterClickSave3 : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI afterText;
    
    public void BtnSave()
    {
        PlayerPrefs.SetString("Day3", afterText.text);
    }
}
