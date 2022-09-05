using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerRotation : MonoBehaviour
{
    private float rotationSpeed = 100;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
