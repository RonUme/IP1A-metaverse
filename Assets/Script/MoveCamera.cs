using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    private GameObject child;
    private Transform childTransform;
    private Transform _cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(0).gameObject;
        childTransform = child.transform;
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

        if (Input.GetKey(KeyCode.D)) { camPos += childTransform.right * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.A)) { camPos -= childTransform.right * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.E)) { camPos += childTransform.up * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.Q)) { camPos -= childTransform.up * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.W)) { camPos += childTransform.forward * Time.deltaTime * moveSpeed; }
        if (Input.GetKey(KeyCode.S)) { camPos -= childTransform.forward * Time.deltaTime * moveSpeed; }

        _cameraTransform.position = camPos;
    }
}
