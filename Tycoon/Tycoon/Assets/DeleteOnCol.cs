using UnityEngine;
using System.Collections;

public class DeleteOnCol : MonoBehaviour {
    public string namer;
	void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == namer)
        {
            Destroy(col.gameObject);
        }
    }
}
