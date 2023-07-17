using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailScriptSN : MonoBehaviour
{
    // Start is called before the first frame update
    private int _sec = 5;
    private TrailRenderer _trailRenderer;

    void Start()
    {
        _trailRenderer = gameObject.GetComponent<TrailRenderer>();
        StartCoroutine(LateCall(_sec));
    }

    IEnumerator LateCall(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        _trailRenderer.enabled = true;
    }
}
