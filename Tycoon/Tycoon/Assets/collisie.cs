using UnityEngine;
using System.Collections;

public class collisie : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Visitor")
        {
            Destroy(col.gameObject);
        }
    }
}
