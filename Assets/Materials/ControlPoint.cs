using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    float xRot, yRot = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;
    public float shootPower;
    public int count = 1;
    public Vector3 originalPosition;
    public int goal = 1;


    void Start() {
        originalPosition = ball.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        shootPower = 100f;
        // transform.position = ball.position;

        // Mover la camara
        if (Input.GetMouseButton(0))
        {
            xRot += Input.GetAxis("Mouse X") * rotationSpeed;
            yRot += Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
        }

        // Pegarle a la pelota, solo permite una vez
        if (Input.GetKeyDown(KeyCode.Space) && count > 0)
        {
            ball.velocity = transform.forward * shootPower;
            count = count - 1;
        }


        // REiniciar la pelota
        if (Input.GetKeyDown(KeyCode.R))
        {
            count = 1;
            ball.velocity = new Vector3(0,0,0);
            ball.transform.position = originalPosition;
            goal = 1;
        }
    }

}
