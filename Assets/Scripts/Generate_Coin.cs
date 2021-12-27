using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate_Coin : MonoBehaviour
{
    public GameObject Coin;
    List<Transform> coinlist;
    // Start is called before the first frame update
    void Start()
    {
        coinlist = new List<Transform>();
        for (int i = 0; i < 42; i++)
        {
            Transform c = Instantiate(Coin.transform);
            Transform p = transform.GetChild(i);
            c.parent = p;
            float rand1 = Random.RandomRange(-1f, 1f);
            float rand2 = Random.RandomRange(-1f, 1f);
            c.localPosition = new Vector3(rand1, p.transform.localPosition.y + 3.5f, rand2);
            
            coinlist.Add(c);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
