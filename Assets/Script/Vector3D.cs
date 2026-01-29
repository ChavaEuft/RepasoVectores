using System;
using UnityEngine;

public class Vector3D : MonoBehaviour
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; }


    public Vector3D()
    { 
        X = 0;
        Y = 0;
        Z = 0;
    }

    public Vector3D(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}