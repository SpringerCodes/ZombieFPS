using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;


public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedIn = 30f;
    [SerializeField] float normalZoom = 60f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = .5f;

    private bool isZoomed;

    private void OnDisable()
    {
        ZoomOut();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Zoom();
        }

    }

    private void Zoom()
    {
        if (isZoomed)
        {
            ZoomOut();

        }
        else
        {
            ZoomIn();

        }

    }

    private void ZoomOut()
    {
        fpCamera.fieldOfView = normalZoom;
        isZoomed = false;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void ZoomIn()
    {
        fpCamera.fieldOfView = zoomedIn;
        isZoomed = true;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }


}
