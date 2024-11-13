using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform endPoint;
    [SerializeField] private LayerMask triggerLayerMask;

    private void OnTriggerEnter(Collider other)
    {
        if (LayerMaskiUtil.ContainsLaer(triggerLayerMask, other.gameObject.layer))
        {
           other.transform.position = endPoint.position;
        }

    }

}
