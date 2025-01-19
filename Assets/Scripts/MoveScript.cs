using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed = 20f, rot = 80f, curSpeed;
    public Vector3 displacement = Vector3.zero;

    // Static score variable for persistence
    public static int score = 1;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // Prevent the object from being destroyed on scene change
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            curSpeed = speed * 20;
        }
        else
        {
            curSpeed = speed;
        }

        transform.Rotate(Vector3.up * rot * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * curSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
    }
}
