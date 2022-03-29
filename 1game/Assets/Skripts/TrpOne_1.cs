using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrpOne_1 : MonoBehaviour
{
    [SerializeField] private float value1 = -11.3877f;
    [SerializeField] private float value2 = 8.5208f;
    [SerializeField] private float value3 = 0.2f;
    [SerializeField] private float _collisionTime;
    private void Start()
    {

    }

    public void Movement()
    {
        transform.DOMove(new Vector3(value1, value2, value3), _collisionTime).SetLoops(2, LoopType.Yoyo);
    }
}
