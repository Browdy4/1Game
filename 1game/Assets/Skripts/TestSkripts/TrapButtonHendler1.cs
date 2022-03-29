using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TrapButtonHendler1 : MonoBehaviour , IPointerDownHandler
{
    [SerializeField] private TrapOne _trapOne;
    [SerializeField] private TrpOne_1 _trapOne1;

    public void OnPointerDown(PointerEventData eventData)
    {
        _trapOne.Movement();
        _trapOne1.Movement();
    }
}
