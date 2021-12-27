using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ManuIntro : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    public int SceneIndexDestination = 1;
    public void OnPointerClick(PointerEventData e)
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("current scene name is: " + scene.name + ", the index is " + scene.buildIndex);
        SceneManager.LoadScene(SceneIndexDestination);
    }
}
