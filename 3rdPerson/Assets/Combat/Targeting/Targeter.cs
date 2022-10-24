using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using System;

public class Targeter : MonoBehaviour
{
    [SerializeField] private CinemachineTargetGroup cineTargetGroup;
    public Target currentTarget { get; private set; }
    public List<Target> targets = new List<Target>();

    private void OnTriggerEnter(Collider other)
    {
        if(!other.TryGetComponent<Target>(out Target target)) { return; }
        target.OnDestroyed += RemoveTarget;
        targets.Add(target);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.TryGetComponent<Target>(out Target target)) { return; }
        RemoveTarget(target);
    }

    public bool SelectTarget()
    {
        if (targets.Count == 0) { return false; }

        currentTarget = targets[0];
        cineTargetGroup.AddMember(currentTarget.transform, 1f, 2f);
        return true;
    }

    public void Cancel()
    {
        if(currentTarget == null) { return; }
        cineTargetGroup.RemoveMember(currentTarget.transform);
        currentTarget = null;
    }

    private void RemoveTarget(Target target)
    {
        if(currentTarget == target)
        {
            cineTargetGroup.RemoveMember(target.transform);
            currentTarget = null;
        }
        target.OnDestroyed -= RemoveTarget;
        targets.Remove(target);
    }
}
