using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotTrigger : MonoBehaviour
{
    public AudioMixerSnapshot SnapshotOut;
    public AudioMixerSnapshot SnapshotIn;
    public void OnTriggerExit(Collider other)
    {
        SnapshotOut.TransitionTo(4f);
    }
    public void OnTriggerEnter(Collider other)
    {
        SnapshotIn.TransitionTo(4f);
    }
}