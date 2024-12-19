using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAnimation : MonoBehaviour
{
    [SerializeField] ParticleSystem[] systems;
    [SerializeField] ParticleSystem[] indexedSystem;
    [SerializeField] private Animator animator;

    public void Play()
    {
        foreach (var s in systems)
            s.Play();
    }

    public void Stop()
    {
        foreach (var s in systems)
            s.Stop();
    }

    public void PlayIndex(int index)
    {
        indexedSystem[index].Play();
    }

    public void StopIndex(int index)
    {
        indexedSystem[index].Stop();
    }

    public void ResetAnimations()
    {
        animator ??= GetComponent<Animator>();
        animator.SetTrigger("ResetTrigger");
}
}
