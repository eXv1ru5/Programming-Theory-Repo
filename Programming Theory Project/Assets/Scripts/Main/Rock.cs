using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Resource
{
    void Update()
    {
        if (userControl.selectedObject != null && userControl.selectedObject.CompareTag("Rock"))
        {
            DisplayTextResource();
        }
    }

    public override void DisplayTextResource()
    {
        typeText.text = "Rock";
        nameText.text = userControl.selectedObject.name;
    }
}
