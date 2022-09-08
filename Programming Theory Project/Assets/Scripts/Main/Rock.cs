using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Resource // INHERITANCE
{
    void Update()
    {
        if (userControl.selectedObject != null && userControl.selectedObject.CompareTag("Rock"))
        {
            DisplayTextResource();
        }
    }

    public override void DisplayTextResource() // POLYMORPHISM
    {
        typeText.text = "Rock";
        nameText.text = userControl.selectedObject.name;
    }
}
