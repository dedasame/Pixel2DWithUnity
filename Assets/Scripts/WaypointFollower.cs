using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints; 
    private int currentWaypointIndex = 0; 

    [SerializeField] private float speed = 2f;


    private void Update()
    {
        // `Vector2.Distance` waypoinler arasi mesafeyi hesaplar.
        // `waypoints` dizisi, oyun i�inde takip edilecek bir dizi konumu (waypoint) i�erir.
        // `currentWaypointIndex` de�i�keni, �u anda takip edilen waypoint'in dizideki indeksini belirtir.
        // `transform.position` ifadesi, bu kodu i�eren nesnenin �u anki konumunu temsil eder.

        // E�er �u anki konum ile `currentWaypointIndex` indeksine sahip waypoint aras�ndaki mesafe 0.1 birimden k���kse: 
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position,transform.position) < .1f) 
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }


        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime*speed); 
        
        
    }
}
