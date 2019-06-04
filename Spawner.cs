using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclepatterns;
    private float timebwspawn;
    public float starttimebwspawn;
    public float decTime;
    public float limit = 0.65f;
    private void Update()
    {
        if (timebwspawn<=0)
        {
            int rand = Random.Range(0, obstaclepatterns.Length);
            Instantiate(obstaclepatterns[rand], transform.position, Quaternion.identity);
            timebwspawn = starttimebwspawn;
            if (starttimebwspawn > limit)
            {
                starttimebwspawn -= decTime;
            }
        }
        else
        {
            timebwspawn -= Time.deltaTime;
        }
        
    }
}
