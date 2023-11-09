using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    public Vector3 targetPos;
    private float smooth = 1f;

    void Start()
    {
        targetPos = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position,targetPos,smooth*Time.deltaTime);
    }
    // public Transform target;
    // public Vector3 offset;
    // [Range(1,10)]
    // public float smoothFactor;

    // private void FixeUpdate()
    // {
    //     Follow();
    // }

    // void Follow ()
    // {
    //     Vector3 targetPosition = target.position + offset;
    //     Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition,smoothFactor * Time.fixedDeltaTime);
    //     transform.position = targetPosition;
    // }
}
