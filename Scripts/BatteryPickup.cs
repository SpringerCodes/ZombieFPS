using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float addIntensity = 1f;
    [SerializeField] float restoreAngle = 90f;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("playercollided outsideif");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("playercollided inside if");
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightIntensity(addIntensity);

            Destroy(gameObject);
        }
    }
}
