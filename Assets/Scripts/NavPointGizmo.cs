using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavPointGizmo : MonoBehaviour
{
    [SerializeField] private float gizmoRadius = 1;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawSphere(transform.position, gizmoRadius);
    }
}
