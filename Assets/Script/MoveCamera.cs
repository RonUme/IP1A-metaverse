using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    private Transform _cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        _cameraTransform = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        CameraPositionKeyControl();
    }

    void CameraPositionKeyControl()
    {
        Vector3 camPos = _cameraTransform.position;

        if (Input.GetKey(KeyCode.D)) { camPos += _cameraTransform.right * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.A)) { camPos -= _cameraTransform.right * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.E)) { camPos += _cameraTransform.up * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.Q)) { camPos -= _cameraTransform.up * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.W)) { camPos += _cameraTransform.forward * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.S)) { camPos -= _cameraTransform.forward * Time.deltaTime * moveSpeed; }

        _cameraTransform.position = camPos;
    }
}
