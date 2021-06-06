using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;


public class ButtonString : MonoBehaviour
{
    public TextMeshProUGUI largeText;
    
    // Method for OnClick button use
    public void BtnAction()
    {
        PickRandoList();
    }

    // Method for choosing a random Cuisine/Recipe
    void PickRandoList()
    {
        string[] students = new string[] 
        {"Aruban: Rice, Beef Stew, Fried Plantain, Aruban Pancake", 
            "ChinaLatina: Rice, Water, Green Onions, Magi Sauce", 
            "Dutch: Split Peas, Water, Beef Bouillon, Smoked Sausage", 
            "Colombian: Rice, Arepa, Patacon, Lentils, Avocado", 
            "Japanese: Rice, Wakame, Edamame, Mango, Salmon", 
            "Mexican: Hard Shell Tortilla, Ground Beef, Lettuce, Sour Cream", 
            "LazyCook: Ramen Pack, Water, Bouillon(Any), Mushrooms"};
        string randomName = students[Random.Range(0, students.Length)];
        largeText.text = randomName.ToString();
    }
}
