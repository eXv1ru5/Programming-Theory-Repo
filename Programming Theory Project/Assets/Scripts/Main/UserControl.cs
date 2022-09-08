using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour
{
    public GameObject selectedObject { get; private set; } // ENCAPSULATION

    // Update is called once per frame
    void Update()
    {
        OnClickRay(); // ABSTRACTION
    }

    void OnClickRay() // ABSTRACTION
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                GameObject hitObject = hitInfo.transform.gameObject;

                SelectObject(hitObject);
            }
            else
            {
                ClearSelection();
            }
        }
    }

    void SelectObject(GameObject obj) // ABSTRACTION
    {
        if (selectedObject != null)
        {
            if (obj == selectedObject)
                return;

            ClearSelection();
        }

        selectedObject = obj;
    }

    void ClearSelection() // ABSTRACTION
    {
        selectedObject = null;
    }
}
