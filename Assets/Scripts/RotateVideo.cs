using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateVideo : MonoBehaviour {

    float rotateSpeed = 150f;

    void OnMouseDrag()
    {
        float rotY = Input.GetAxis("Mouse Y") * rotateSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, rotY);
    }
}
