using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AI;
using Unity.AI.Navigation;

public class AutoBaker : MonoBehaviour
{
    private NavMeshSurface _navMeshSurface;

    private void Awake()
    {
        _navMeshSurface = GetComponent<NavMeshSurface>();
        BakeSurface();
    }

    public void BakeSurface()
    {
        _navMeshSurface.BuildNavMesh();
    }
}
