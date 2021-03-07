using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Type1_NPC : NPC
{
    [SerializeField]
    private GameObject waypointRoot;
    private Waypoint_Position[] waypoints;
    private Waypoint_Position currentWaypoint;
    private Vector3 currentTarget;

    private void Start()
    {
        waypoints = waypointRoot.GetComponentsInChildren<Waypoint_Position>();
        setDestination(waypoints[Random.Range(0, waypoints.Length)]);
    }

    protected override void move()
    {

        if(Vector3.Distance(gameObject.transform.position, currentTarget) < 2)
        {
            setDestination(waypoints[Random.Range(0, waypoints.Length)]);
        }

    }

    protected void setDestination(Waypoint_Position wp)
    {
        currentWaypoint = wp;
        currentTarget = currentWaypoint.position;
        print($"nma: {nma}");
        nma.SetDestination(currentTarget);
    }

}
