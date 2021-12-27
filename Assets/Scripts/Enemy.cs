using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    bool viking_colliding = false;
    int direction = 0;
    float r = 0;
    public Vector3 MovingDirection;
    public float movingSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        viking_colliding = GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().colliding;
        direction = GameObject.Find("Detection").GetComponent<Detect_Controller>().direction;
        if (viking_colliding)
        {
            if (direction == 0)
            {
                MovingDirection = new Vector3(0, 0, 1);
                r = 270;
            }
            else if (direction == 1)
            {
                MovingDirection = new Vector3(0, 0, 1);
                r = 0;
            }
            else if (direction == 2)
            {
                MovingDirection = new Vector3(0, 0, 1);
                r = 180;
            }
            transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;
            transform.localRotation= Quaternion.Euler(transform.localRotation.x, r, transform.localRotation.z);
            viking_colliding = GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().touch_enemy;
        }
    }
}
