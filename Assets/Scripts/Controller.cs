using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    public int score;
    public float timer_f = 0f;
    public int timer_i = 0;
    public bool fail = false;
    bool falling, colliding;
    int SceneIndexDestination=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().coin_score;
        falling= GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().falling;
        colliding= GameObject.Find("Viking_Axes").GetComponent<VikingRunning>().colliding;
        timer_f += Time.deltaTime;
        timer_i=(int)timer_f;
        if(falling || colliding)
        {
            fail = true;
            PlayerPrefs.SetInt("SCORE", score);
            PlayerPrefs.SetInt("TIME", timer_i);
            SceneIndexDestination = 3;
            StartCoroutine(waiter());
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(SceneIndexDestination);
        }
        //Debug.Log(score + "  " + timer_i);
        IEnumerator waiter()
        {
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene(SceneIndexDestination);
        }
        }
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneIndexDestination);
    }
}
