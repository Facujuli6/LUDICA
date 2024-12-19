using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAssembler : MonoBehaviour
{
    [SerializeField] private IRobot robot;

    private void Start()
    {
        robot = FindObjectOfType<IRobot>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Part"))
        {
            robot.FindPart(other.name);
            Destroy(other.GetComponentInParent<Rigidbody>().gameObject);
        }
    }
}
