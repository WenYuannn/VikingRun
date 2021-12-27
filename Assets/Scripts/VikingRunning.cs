using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
[RequireComponent(typeof(Animator))]
public class VikingRunning : MonoBehaviour
{
    // Start is called before the first frame update
    public float JumpingForce=400;
    public bool jumping=false;
    public bool falling =false;
    public bool colliding = false;
    public bool touch_enemy = false;
    public int coin_score = 0;
    int direction = 0;
    Rigidbody rb;
    Animator animator;
    Transform t;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator=GetComponent<Animator>();
        t = GetComponent<Transform>();
        animator.SetBool("Jumping", jumping);
        animator.SetBool("Falling", falling);
        animator.SetBool("Colliding", colliding);
    }
    // Update is called once per frame
    void Update()
    {
        direction = GameObject.Find("Detection").GetComponent<Detect_Controller>().direction;
        StartCoroutine(changeDirection(direction));
        if (!jumping && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(JumpingForce * Vector3.up);
            jumping = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetBool("Running", true);
        }
        animator.SetBool("Jumping", jumping);
        animator.SetBool("Falling", falling);
        animator.SetBool("Colliding", colliding);
        if (direction == 0)
        {
           
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.localPosition = new Vector3(transform.localPosition.x - 2, transform.localPosition.y, transform.localPosition.z);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.localPosition = new Vector3(transform.localPosition.x + 2, transform.localPosition.y, transform.localPosition.z);
            }
        }
        else if (direction == 1)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.localPosition = new Vector3(transform.localPosition.x , transform.localPosition.y, transform.localPosition.z+2);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.localPosition = new Vector3(transform.localPosition.x , transform.localPosition.y, transform.localPosition.z-2);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.localPosition = new Vector3(transform.localPosition.x , transform.localPosition.y, transform.localPosition.z-2);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.localPosition = new Vector3(transform.localPosition.x , transform.localPosition.y, transform.localPosition.z+2);
            }
        }
        if (transform.localPosition.y < -5)
        {
            falling = true;
        }
        IEnumerator changeDirection(int dir)
        {
            bool end = false;
            int count = 0;
            if (transform.localRotation.y == 0)
            {
                if (dir == 1)
                {
                    while (!end)
                    {
                        count++;
                        transform.localRotation = Quaternion.Euler(transform.localRotation.x, count, transform.localRotation.z);
                        if (count == 90) end=true;
                        yield return new WaitForSeconds(0.001f);
                    }
                }
                else if (dir == 2)
                {
                    while (!end)
                    {
                        count--;
                        transform.localRotation = Quaternion.Euler(transform.localRotation.x, count, transform.localRotation.z);
                        if (count == -90) end = true;
                        yield return new WaitForSeconds(0.001f);
                    }
                }
            }
            if (transform.localRotation.y == 0.7071068f)
            {
                if (dir == 0)
                {
                    count = 90;
                    while (!end)
                    {
                        count--;
                        transform.localRotation = Quaternion.Euler(transform.localRotation.x, count, transform.localRotation.z);
                        if (count == 0) end = true;
                        yield return new WaitForSeconds(0.001f);
                    }
                } 
            }
            if (transform.localRotation.y == -0.7071068f)
            {
                if (dir == 0)
                {
                    count = -90;
                    while (!end)
                    {
                        count++;
                        transform.localRotation = Quaternion.Euler(transform.localRotation.x, count, transform.localRotation.z);
                        if (count == 0) end = true;
                        yield return new WaitForSeconds(0.001f);
                    }
                }
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.transform.name);
        if (collision.transform.name== "module_02_tile_02_ac_floor")
        {
            jumping = false;
        }
        if (collision.transform.name == "crossbar")
        {
            colliding = true;
        }
        if(collision.transform.name== "Viking_Sword")
        {
            touch_enemy = true;
        }
        if (collision.transform.name == "Viking_Shield 1(Clone)")
        {
            coin_score++;
        }
    }
}
