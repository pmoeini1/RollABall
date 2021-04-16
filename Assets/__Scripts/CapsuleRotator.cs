using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleRotator : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        // Rotate the capsule by 30 in the X axis,
        // 60 in the Y axis and 90 in the Z axis, multiplied by deltaTime in order to make it per second
        transform.Rotate(new Vector3(30, 60, 90) * Time.deltaTime);
    }
}
