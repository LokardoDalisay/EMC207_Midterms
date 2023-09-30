using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField]private Transform target;
    private Vector3 offset;
    [SerializeField] private float smooth_time;
    private Vector3 velocity = Vector3.zero;

    private void Awake()
    {
        offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        var target_position = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, target_position, ref velocity, smooth_time);
    }
}
