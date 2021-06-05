using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AfterClickSave2 : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI afterText;
    
    public void BtnSave()
    {
        PlayerPrefs.SetString("Day2", afterText.text);
    }
}
