using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class JumpButtonHendler : MonoBehaviour , IPointerDownHandler
{
    [SerializeField] private CharacterJumpHendler _characterJumpHendler;

    public void OnPointerDown(PointerEventData eventData)
    {
        _characterJumpHendler.HandleJump();
    }
}
