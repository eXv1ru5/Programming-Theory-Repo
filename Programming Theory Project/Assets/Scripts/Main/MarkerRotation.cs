using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRotation : MonoBehaviour
{
    private float rotationSpeed = 100;

    // Update is called once per frame
    void Update()
    {
        RotateY();
    }

    void RotateY() // ABSTRACTION
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
