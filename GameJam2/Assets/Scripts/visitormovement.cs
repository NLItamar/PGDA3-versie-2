using UnityEngine;
using System.Collections;

public class visitormovement : MonoBehaviour {

    public GameObject go1;
    public GameObject go2;
    public GameObject go3;

    bool check1 = true;
    bool check2 = false;
    bool check3 = false;

    NavMeshAgent agent;
    Vector3 destination;
	
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }
	// Update is called once per frame
	void Update ()
    {
        if(check1)
        {
            agent.SetDestination(go1.transform.position);
            secondFloor();
        }

        if(check2)
        {
            thirdFloor();
        }
    }

    void secondFloor()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    agent.SetDestination(go2.transform.position);
                    check1 = false;
                    check2 = true;
                }
            }
        }
    }

    void thirdFloor()
    {
        fourthFloor();
    }

    void fourthFloor()
    {
        if (!agent.pathPending)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                {
                    agent.SetDestination(go3.transform.position);
                    check2 = false;
                    check3 = true;
                }
            }
        }
    }
}
