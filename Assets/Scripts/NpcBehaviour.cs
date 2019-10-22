using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] targetPoints;
    private GameObject currentPoint;
    private int index;

    private void Start()
    {
        targetPoints = GameObject.FindGameObjectsWithTag("targets");
        index = Random.Range(0, targetPoints.Length);
        currentPoint = targetPoints[index];
    }


    private void Update()
    {
        agent.SetDestination(currentPoint.transform.position);
    }
}
