using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfterClickSave4 : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI afterText;
    
    public void BtnSave()
    {
        PlayerPrefs.SetString("Day4", afterText.text);
    }
}
