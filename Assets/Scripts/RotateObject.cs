using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    float rotateSpeed = 150f;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotateSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
    }
}
