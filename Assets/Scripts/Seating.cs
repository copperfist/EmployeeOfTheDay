using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seating : MonoBehaviour
{
    public bool canLeave = false;
    private float leaveTimer = 0.5f;

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("joystick button 0") && other.CompareTag("NPC"))
        {
            canLeave = true;         
        }

    }
    private void OnTriggerExit(Collider other)
    {
         leaveTimer -= Time.deltaTime;

        Debug.Log(leaveTimer);

        if(leaveTimer <= 0)
        {
            canLeave = false;
            leaveTimer = 0.5f;
        }
    }
}