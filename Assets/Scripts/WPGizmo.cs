using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WPGizmo : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private float gizmoRadius = 1;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = color;
        Gizmos.DrawSphere(transform.position, gizmoRadius);
    }
}
