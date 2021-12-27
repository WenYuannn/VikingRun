using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public int SceneIndexDestination = 0;
    public void OnPointerClick(PointerEventData e)
    {

        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(SceneIndexDestination);
    }
}
