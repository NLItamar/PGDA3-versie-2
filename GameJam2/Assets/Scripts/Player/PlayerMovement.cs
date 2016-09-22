using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public float zmove;
    public float ymove;
    private Quaternion m_OriginalRotation;
    private SimpleMouseRotator rotatorScript;


    void Start()
    {

        m_OriginalRotation = transform.localRotation;
        rotatorScript = GetComponentInChildren<SimpleMouseRotator>();
    }

    void Update()
    {
        Screen.lockCursor = true;
        Screen.lockCursor = false;
        transform.localRotation = m_OriginalRotation * Quaternion.Euler(0, rotatorScript.m_FollowAngles.y, 0);

        zmove =  moveSpeed * Time.deltaTime;
        
        
        
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(horizontal, 0, 0);
        
        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, zmove);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, -zmove);
        }
        if (Input.GetKey("z"))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey("x"))
        {
            transform.Translate(0, -0.1f, 0);
        }


    }
}
