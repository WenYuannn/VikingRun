using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public int direction=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("detect1").GetComponent<Detect>().entering && GameObject.Find("detect1").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect1").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect2").GetComponent<Detect>().entering && GameObject.Find("detect2").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect2").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect3").GetComponent<Detect>().entering && GameObject.Find("detect3").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect3").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect4").GetComponent<Detect>().entering && GameObject.Find("detect4").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect4").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect5").GetComponent<Detect>().entering && GameObject.Find("detect5").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect5").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect6").GetComponent<Detect>().entering && GameObject.Find("detect6").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect6").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect7").GetComponent<Detect>().entering && GameObject.Find("detect7").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect7").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect8").GetComponent<Detect>().entering && GameObject.Find("detect8").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect8").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect9").GetComponent<Detect>().entering && GameObject.Find("detect9").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect9").GetComponent<Detect>().direction;
        }
        else if (GameObject.Find("detect10").GetComponent<Detect>().entering && GameObject.Find("detect10").GetComponent<Detect>().click)
        {
            direction = GameObject.Find("detect10").GetComponent<Detect>().direction;
        }
        //Debug.Log(direction);
    }
}
