using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Seating : MonoBehaviour
{

    
    public bool isTaken = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            isTaken = true;            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            isTaken = false;
        }
    }
}
