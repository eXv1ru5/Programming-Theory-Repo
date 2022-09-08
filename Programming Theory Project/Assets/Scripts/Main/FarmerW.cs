using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerW : Farmer
{

    void Update()
    {
        if (userControl.selectedObject != null && userControl.selectedObject.CompareTag("FarmerW"))
        {
            DisplayTextFarmer();
            speed = -10;
        }        
    }

    public override void DisplayTextFarmer()
    {
        typeText.text = "FarmerW";
        nameText.text = userControl.selectedObject.name;
    }
}
