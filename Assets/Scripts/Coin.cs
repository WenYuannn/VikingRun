using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Collider))]
public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Viking_Axes")
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - 10, transform.localPosition.z);
            StartCoroutine(waiter());
        }
        IEnumerator waiter()
        {
            yield return new WaitForSeconds(1f);
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + 10, transform.localPosition.z);

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    } 
}
