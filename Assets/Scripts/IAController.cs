using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class IAController : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

    public Transform[] destinationPoints;
    public int destinationIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Target").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target.position) < 30)
        {
            agent.destination = target.position;
        }

        if(Vector3.Distance(transform.position, target.position) < 5)
        {
            Debug.Log("Atacando");
        }
        else
        {
            agent.destination = destinationPoints[destinationIndex].position;

            if(Vector3.Distance(transform.position, destinationPoints[destinationIndex].position) < 0.5f)
            {
                if(destinationIndex < destinationPoints.Length - 1)
                {
                    destinationIndex++;
                }
                else
                {
                destinationIndex = 0;
                }
            }   
        }
    }
}