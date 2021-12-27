using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ground : MonoBehaviour
{
    Animator animator;
    public Vector3 MovingDirection;
    float movingSpeed = 0f;
    int direction = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        bool falling=GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().falling;
        bool colliding=GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().colliding;
        direction = GameObject.Find("Detection").GetComponent<Detect_Controller>().direction;
        if (Input.GetKeyDown(KeyCode.R))
        {
            movingSpeed = 25f;
        }
        if (falling || colliding)
        {
            movingSpeed = 0;
        }
        if (direction == 0)
        {
            MovingDirection = new Vector3(0, 0, -1);
        }
        else if (direction == 1)
        {
            MovingDirection = new Vector3(-1, 0, 0);
        }
        else if (direction == 2)
        {
            MovingDirection = new Vector3(1, 0, 0);
        }
        if (!falling &&!colliding)
        {
            transform.localPosition += movingSpeed * Time.deltaTime * MovingDirection;
        }
        if (transform.localPosition.z <= -60 && direction==0)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 370);
        }
        
    }
}
