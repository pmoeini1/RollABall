using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstant : MonoBehaviour
{
    // declare cube, capsule, and cylinder pickups
    public GameObject cube;
    public GameObject capsule;
    public GameObject cylinder;

    void Start()
    {
        float[] cubeLocations = { 1, -3, 5, -6 };
        float[] capsuleLocations = { -1, 7, 3, 2 };
        float[] cylinderLocations = { 2, -4, -5, 5 };
        for (int i = 0; i < 3; i++)
        {
            // put cubes at (1, 0.5, -3), (-3, 0.5, 5), (5, 0.5, -6)
            Instantiate(cube, new Vector3(cubeLocations[i], 0.5f, cubeLocations[i + 1]), Quaternion.identity);
            // put capsules at (-1, 0.5, 7), (7, 0.5, 3), (3, 0.5, 2)
            Instantiate(capsule, new Vector3(capsuleLocations[i], 0.5f, capsuleLocations[i + 1]), Quaternion.identity);
            // put cylinders at (2, 0.8, -4), (-4, 0.8, -5), (-5, 0.8, 5)
            Instantiate(cylinder, new Vector3(cylinderLocations[i], 0.8f, cylinderLocations[i + 1]), Quaternion.identity);
        }
    }
}


