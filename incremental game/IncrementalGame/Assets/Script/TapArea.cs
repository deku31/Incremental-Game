using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapArea : MonoBehaviour,IPointerDownHandler
{
    public AudioSource sound;
    public void OnPointerDown(PointerEventData eventData)
    {
        sound.Play();
        GameManager.Instance.CollectByTap(eventData.position, transform);
    }
   
}
