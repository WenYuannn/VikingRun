using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 MovingDirection;
    public Quaternion MovingRotation;
    float movingSpeed = 15f;
    float tmpx = -0.33f, tmpy = 5.03f, tmpz = 6.33f, rtmp = 180f;
    bool end = false;
    int count = 0;
    void Start()
    {
        MovingDirection = new Vector3(-0.33f, 5.03f, 6.33f);
        MovingRotation = Quaternion.Euler(15f, 180f, 0);
        transform.localPosition = MovingDirection;
        transform.localRotation = MovingRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(!end)
            StartCoroutine(waiter());
        IEnumerator waiter()
        {
            while (!end)
            {
                count++;
                rtmp += 0.18f;
                tmpx += 1.9e-4f;
                tmpy = tmpy;
                tmpz -= 0.01299f;
                MovingDirection = new Vector3(tmpx, tmpy, tmpz);
                MovingRotation = Quaternion.Euler(15f, rtmp, 0);
                transform.localPosition = MovingDirection;
                transform.localRotation = MovingRotation;
                if (count == 999) end = true;
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
