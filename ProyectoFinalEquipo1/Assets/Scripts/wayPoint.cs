using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayPoint : MonoBehaviour
{
  public List<Transform> waypoints = new List<Transform>();
      private Transform targetWaypoint;
      private int targetWaypointIndex = 0;
      private float minDistance = 0.1f;
      private float speed = 5.0f;
      private int listSize = 0;
      private int counter = 0;
      private float rotationSpeed = 2.0f;
      
      // Start is called before the first frame update
      void Start()
      {
          targetWaypoint = waypoints[targetWaypointIndex];
          listSize = waypoints.Count-1;
      }
  
      // Update is called once per frame
      void Update()
      {
          //Rotacion
          float rotationStep = rotationSpeed * Time.deltaTime;
          Vector3 directionToTarget = targetWaypoint.position - transform.position;
          Quaternion rotationTarget = Quaternion.LookRotation(directionToTarget);
          transform.rotation = rotationTarget;
          
          Vector3 currentPos = transform.position;
          
          if (currentPos == targetWaypoint.position)
          {
              if (counter < listSize)
              {
                  counter++;
              }
  
              targetWaypoint = waypoints[counter];
              Debug.Log("Cambie");
          }
          transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, Time.deltaTime * speed);
          //Para hacer rotacion mas lenta
          //transform.rotation = Quaternion.Slerp(transform.rotation, rotationTarget, rotationStep);
      }
}
