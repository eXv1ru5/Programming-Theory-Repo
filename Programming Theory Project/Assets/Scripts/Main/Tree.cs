using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Resource // INHERITANCE
{
    void Update()
    {
        if (userControl.selectedObject != null && userControl.selectedObject.CompareTag("Tree"))
        {
            DisplayTextResource();
        }
    }

    public override void DisplayTextResource() // POLYMORPHISM
    {
        typeText.text = "Tree";
        nameText.text = userControl.selectedObject.name;
    }
}
