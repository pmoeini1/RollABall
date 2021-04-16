using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Rotate the cylinder to by 90 in the Z axis, multiplied by deltaTime in order to make it per second
        transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime);
    }
}
