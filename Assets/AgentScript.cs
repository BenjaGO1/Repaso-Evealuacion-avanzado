using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform destinationTransform;
    public float remainingDistance;
    [SerializeField] Transform[] targets;
    [SerializeField] int currentTarget;
    [SerializeField] float arraivingdistance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = targets[currentTarget].position;
        patrullaje();
        
    }
    void patrullaje()
    {
        if (Vector3.Distance(transform.position,targets[currentTarget].position) < arraivingdistance)
        {
            if (currentTarget <targets.Length -1)
            {
                currentTarget++;
            }
            else
            {
                currentTarget = 0;
            }
        }
    }
}
