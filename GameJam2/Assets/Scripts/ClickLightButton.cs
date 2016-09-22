using UnityEngine;
using System.Collections;

public class ClickLightButton : MonoBehaviour
{
    public Light LightSource;
    public float range;
    Ray ray;
    RaycastHit hit;

    public int count = 0;
    public bool clicked = false;


    void FixedUpdate()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        Physics.Raycast(ray, out hit,range);
        //Debug.Log(hit.transform.gameObject.name);

        if (clicked)
        {
            count++;
            if (count % 5 == 0 && count <= 60)
            {
                LightSource.enabled = !LightSource.enabled;
            }



            if (count >= 60)
            {
                count = 0;
                clicked = false;
            }
        }
    }


    void OnMouseOver()
    {

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.transform.gameObject.name == "Light Switch")
                {
                //LightSource.enabled = !LightSource.enabled;
                
                clicked = true;
                }
            }        
        
    }
}
