using UnityEngine;
using System.Collections;

public class Army2Movement : MonoBehaviour
{

    public GameObject Army1;
    //public GameObject ExitArea;

    bool army1Check;
    //bool exitAreaBool;
    //bool exit;

    NavMeshAgent agent;
    Vector3 destination;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
        army1Check = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (army1Check)
        {
            agent.SetDestination(Army1.transform.position);
            //call method to set next destination
            nextDestination();
        }
        /*if(exitAreaBool)
        {
            setNextDestination();
        }
        if(exit)
        {
            Destroy(this.gameObject);
        }*/
    }

    //call when the two collide
    void nextDestination()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= /*agent.stoppingDistance +*/ 2f)
            {
                Destroy(this.gameObject);
                Destroy(Army1);
                //if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                //{
                    //agent.SetDestination(ExitArea.transform.position);
                    //army1Check = false;
                    //exitAreaBool = true;
                //}
            }
        }
    }

    /*void setNextDestination()
    {
        agent.SetDestination(ExitArea.transform.position);
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance + 2f)
            {
                //if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                //{
                agent.SetDestination(ExitArea.transform.position);
                exitAreaBool = false;
                exit = true;
                //}
            }
        }
    }*/
}
