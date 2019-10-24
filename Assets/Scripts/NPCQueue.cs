using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCQueue : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject Seat1;
    public GameObject Seat2;

    private GameObject currentWaypoint;
    private int index = 0;

    private void Start()
    {
        Seat1 = GameObject.FindGameObjectWithTag("Seats");
        Seat2 = GameObject.FindGameObjectWithTag("Seat2");

        currentWaypoint = Seat1;
    }

    private void Update()
    {

        if (GameObject.Find("Seating").GetComponent<Seating>().isTaken != true)
        {
            agent.SetDestination(currentWaypoint.transform.position);
        }
        else
        {
            Debug.Log("Going to seat 2");
            currentWaypoint = Seat2;
            agent.SetDestination(currentWaypoint.transform.position);
        }
    }

}
