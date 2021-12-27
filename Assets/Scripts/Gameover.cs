using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    // Start is called before the first frame update
    int score, timer;
    public Text gameover;
    void Start()
    {
        score=PlayerPrefs.GetInt("SCORE", 0);
        timer= PlayerPrefs.GetInt("TIME", 0);
        gameover.text = "Game over\nYour Score: "+score+"\nYour Time: "+timer;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
