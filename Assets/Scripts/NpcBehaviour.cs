using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
<<<<<<< HEAD
    public GameObject[] targetPoints;
    private GameObject currentPoint;
    private int index;
=======
    public GameObject[] targetWaypoints;
    public GameObject tillWaypoint;
    public GameObject exitWaypoint;


    private GameObject currentWaypoint;
    private int index;
    private float minDistance = 0.3f;
    private float distance;
>>>>>>> parent of 7b4ea67... Npc Loop

    private void Start()
    {
<<<<<<< HEAD
        targetPoints = GameObject.FindGameObjectsWithTag("targets");
        index = Random.Range(0, targetPoints.Length);
        currentPoint = targetPoints[index];
=======
        targetWaypoints = GameObject.FindGameObjectsWithTag("targets");
        tillWaypoint = GameObject.FindGameObjectWithTag("tillPayment");
        index = Random.Range(0, targetWaypoints.Length);
        currentWaypoint = targetWaypoints[index];
        Debug.Log("Going to" + currentWaypoint);
>>>>>>> parent of 7b4ea67... Npc Loop
    }


    private void Update()
    {
<<<<<<< HEAD
        agent.SetDestination(currentPoint.transform.position);
    }
=======
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
>>>>>>> parent of 7b4ea67... Npc Loop
}
