using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vechle : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 1f;
    private int currentWaypoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentWaypoint < waypoints.Length)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypoint].position, speed * Time.deltaTime);
            
           
            // Calculate the direction to the next waypoint
            Vector3 direction = waypoints[currentWaypoint].position - transform.position;
            direction.y = 0; // Set the y-component to zero to prevent the player from tilting
            

            if (direction != Vector3.zero)
            {
                // Rotate the player to face the next waypoint
                transform.rotation = Quaternion.LookRotation(direction);
            }

            if (transform.position == waypoints[currentWaypoint].position)
            {
                currentWaypoint++;
            }
            if (currentWaypoint == waypoints.Length)
            {
                currentWaypoint = 0;
            }
        }
    }
}
