using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerM : Farmer // INHERITANCE
{

    void Update()
    {
        if (userControl.selectedObject != null && userControl.selectedObject.CompareTag("FarmerM"))
        {
            DisplayTextFarmer();
        }
    }

    public override void DisplayTextFarmer() // POLYMORPHISM
    {
        typeText.text = "FarmerM";
        nameText.text = userControl.selectedObject.name;
    }
}
