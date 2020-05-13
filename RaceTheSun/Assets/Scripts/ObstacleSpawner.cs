using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public float maxTime = 1;
    public float timer = 0;
    public GameObject obstacles;
    public float displacement;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObstacles = Instantiate(obstacles);
        newObstacles.transform.position = transform.position + new Vector3(Random.Range(-displacement, displacement),6,0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newObstacles = Instantiate(obstacles);
            newObstacles.transform.position = transform.position + new Vector3(Random.Range(-displacement, displacement), 6, 0);
            Destroy(newObstacles, 8);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
