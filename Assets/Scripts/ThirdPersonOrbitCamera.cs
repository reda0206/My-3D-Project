using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonOrbitCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 2, -5);
    public float rotationSpeed = 5f;
    public float minY = -20f;
    public float MaxY = 60f;

    private float currentX = 0f;
    private float currentY = 20f;
    private void LateUpdate()
    {
        currentX += Input.GetAxis("Mouse X") * rotationSpeed;
        currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;

        currentY = Mathf.Clamp(currentY, minY, MaxY);

        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        Vector3 desiredPosition = target.position + rotation * offset;

        transform.position = desiredPosition;
        transform.LookAt(target);
    }
}
