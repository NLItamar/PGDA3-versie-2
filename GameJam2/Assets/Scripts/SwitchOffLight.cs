using UnityEngine;
using System.Collections;

public class SwitchOffLight : MonoBehaviour
{
    public Material MaterialOn;
    public Material MaterialOff;
    public Light LampLight;

    void FixedUpdate()
    {
        MeshRenderer my_renderer = GetComponent<MeshRenderer>();

        if (LampLight.enabled)
        {
            my_renderer.material = MaterialOn;
        }
        else
        {
            my_renderer.material = MaterialOff;
        }
    }
}
