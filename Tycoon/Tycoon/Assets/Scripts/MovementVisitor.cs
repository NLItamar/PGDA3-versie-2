using UnityEngine;
using System.Collections;

public class MovementVisitor : MonoBehaviour
{
    Transform Target;
    public GameObject go;
    GameObject shop;
    NavMeshAgent nav;
    public int next;
    public int nexta;
    bool checkers = false;
    public string namertoclodie ;
    public string colding;
    // Use this for initialization
    void Start()
    {

        next = Random.Range(0, 2);
        if (next == 1)
        {
            go = GameObject.Find("gate a");
        }
        else
        {
            go = GameObject.Find("gate b");
        }
        Target = go.transform.GetChild(2);

        if (GameObject.Find("ShopCollector").GetComponent<MouseCast>().shopps.Count > 0)
        {
            nexta = Random.Range(-1, GameObject.Find("ShopCollector").GetComponent<MouseCast>().shopps.Count);
            if (nexta > -1) { shop = GameObject.Find("ShopCollector").GetComponent<MouseCast>().shopps[nexta];
                namertoclodie = shop.name;

            }
        }
        else
        {
            checkers = true;
        }

        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (checkers || nexta == -1)
        {
            nav.SetDestination(Target.position);
        }
        else
        {
            nav.SetDestination(shop.transform.GetChild(2).GetChild(0).position);
        }

    }

    void OnCollisionEnter(Collision col)
    {
        colding = col.gameObject.name;
        if (shop != null)
        {
            if (col.gameObject.name == shop.name)
            {
                checkers = true;
            }
        }
    }
}
