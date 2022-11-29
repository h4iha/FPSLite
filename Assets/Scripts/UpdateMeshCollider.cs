using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMeshCollider : MonoBehaviour
{
    [SerializeField] private MeshCollider meshCollider;
    [SerializeField] private SkinnedMeshRenderer skinnedMeshRenderer;
    void Update()
    {
        Mesh colliderMesh = new Mesh();
        skinnedMeshRenderer.BakeMesh(colliderMesh);
        meshCollider.sharedMesh = null;
        meshCollider.sharedMesh = colliderMesh;
        if (meshCollider.sharedMesh == null) Debug.LogWarning(meshCollider.sharedMesh);
    }
}
