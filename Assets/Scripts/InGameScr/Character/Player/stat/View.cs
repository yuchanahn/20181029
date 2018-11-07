using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    GameObject cameraObject;
    Camera cam;
    const int defaultCameraY = 5;
    Vector3 pos;
    void Start()
    {
        cameraObject = GameObject.FindGameObjectWithTag("MainCamera");

        cam = cameraObject.GetComponent<Camera>();
        CameraUpdate();
    }

    // Update is called once per frame
    void Update()
    {


        CameraUpdate();
    }

    private void CameraUpdate()
    {
        pos = new Vector3(cameraObject.transform.position.x,
            defaultCameraY - cam.orthographicSize 
            , cameraObject.transform.position.z);

        cameraObject.transform.position = pos;
    }
}