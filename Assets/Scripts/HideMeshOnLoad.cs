using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMeshOnLoad : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }
}
