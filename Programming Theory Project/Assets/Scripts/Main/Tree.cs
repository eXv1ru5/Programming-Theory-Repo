using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Resource
{
    void Update()
    {
        if (userControl.selectedObject != null && userControl.selectedObject.CompareTag("Tree"))
        {
            DisplayTextResource();
        }
    }

    public override void DisplayTextResource()
    {
        typeText.text = "Tree";
        nameText.text = userControl.selectedObject.name;
    }
}
