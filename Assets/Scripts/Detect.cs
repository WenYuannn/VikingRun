using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Detect : MonoBehaviour
{
    // Start is called before the first frame update
    public int direction;
    public bool entering;
    public bool click;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Viking_Axes")
        {
            entering = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Viking_Axes")
        {
            entering = false;
        }
    }
    void Start()
    {
        direction = 0;
        entering = false;
        click = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            click = true;
        }
        else
        {
            click = false;
        }
        if (entering)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                direction = GameObject.Find("Detection").GetComponent<Detect_Controller>().direction;
                if (direction == 0)
                    direction = 1;
                else if (direction == 2)
                {
                    direction = 0;
                }
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                direction = GameObject.Find("Detection").GetComponent<Detect_Controller>().direction;
                if (direction == 0)
                    direction = 2;
                else if (direction == 1)
                    direction = 0;
            }
        }
    }
}
