using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float sensitivity = 2f;
    private float rotationX = 0f;

    void Update()
    {
        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);
        
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotationX += mouseY * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -85f, 85f);

        transform.Rotate(Vector3.up * mouseX * sensitivity);
        Camera.main.transform.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
    }
}
