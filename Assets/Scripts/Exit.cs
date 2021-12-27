using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Exit : MonoBehaviour,IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData e)
    {
        Application.Quit();
    }
}
