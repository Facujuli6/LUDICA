using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VInspector;

public class IRobot : MonoBehaviour
{
    [SerializeField] private List<GameObject> parts;
    
    [Button]
    public void AutoAdd()
    {
        parts ??= new List<GameObject>();
        foreach (Transform child in transform)
            parts.Add(child.gameObject);
    }
    
    private void Start() => parts ??= new List<GameObject>();

    public void FindPart(string pieceName)
    {
        GameObject part = parts.Find(part => part.name == pieceName);
        if (part == null) return;
        part.SetActive(true);
    }
}
