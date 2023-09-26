using UnityEngine;

public class DisableAfterTime : MonoBehaviour
{
    public float disableTime = 10f;

    private void Start()
    {
        Invoke("DisableObject", disableTime);
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }
}