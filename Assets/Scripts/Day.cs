using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day : MonoBehaviour
{
    public float z;
    // Update is called once per frame
    void Update()
    {

        this.transform.RotateAround (Vector3.zero, Vector3.right, z);
        
    }
}
