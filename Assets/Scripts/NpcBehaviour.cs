using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] targetWaypoints;
    public GameObject tillWaypoint;
    public GameObject exitWaypoint;


    private GameObject currentWaypoint;
    private int index;
    private float minDistance = 0.3f;
    private float distance;

    private void Start() //Pick a random waypoint to start
    {
        targetWaypoints = GameObject.FindGameObjectsWithTag("targets");
        tillWaypoint = GameObject.FindGameObjectWithTag("tillPayment");
        index = Random.Range(0, targetWaypoints.Length);
        currentWaypoint = targetWaypoints[index];
        Debug.Log("Going to" + currentWaypoint);
    }


    private void Update()
    {
        distance = Vector3.Distance(transform.position, currentWaypoint.transform.position);
        Debug.Log(distance);
        CheckDistanceToWaypoint(distance);
        agent.SetDestination(currentWaypoint.transform.position);

    }

    void CheckDistanceToWaypoint(float currentDistance)
    {
        if(currentDistance <= minDistance)
        {
            Debug.Log("To the till");
            SendToTill();
        }
    }
    void SendToTill()
    {
        currentWaypoint.transform.position = tillWaypoint.transform.position;
    }
}
