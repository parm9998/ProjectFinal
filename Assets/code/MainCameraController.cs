using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    public float dampTime = 0.15f;
    // public bool LockX,LockY,LockZ;
    public Vector3 velocity = Vector2.zero;
    public Transform target;
    Camera camera;
    // private const float SMOOTH_TIME = 0.3f;
    // public bool LockX,LockY,LockZ;
    // public float offSetZ = -10f;
    // public bool useSmoothing = true;
    // // public Transform target;
    // private Transform thisTransform;
    // private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 point = camera.WorldToViewportPoint(target.position);
            Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
            Vector3 destination = transform.position + delta;
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
        }

        //  var newPos = Vector3.zero;
        // if(useSmoothing){
        //     newPos.x = Mathf.SmoothDamp(thisTransform.position.x,target.position.x,ref velocity.x,SMOOTH_TIME);
        //     newPos.x = Mathf.SmoothDamp(thisTransform.position.y,target.position.y,ref velocity.y,SMOOTH_TIME);
        //     newPos.x = Mathf.SmoothDamp(thisTransform.position.z,target.position.z + offSetZ,ref velocity.z,SMOOTH_TIME);
        // }else{
        //     newPos.x = target.position.x;
        //     newPos.y = target.position.y;
        //     newPos.z = target.position.z;
        // }

        // if(LockX){
        //     newPos.x = thisTransform.position.x;
        // }
        // if(LockY){
        //     newPos.y = thisTransform.position.y;
        // }
        // if(LockZ){
        //     newPos.z = thisTransform.position.z;
        // }
        // transform.position = Vector3.Slerp(thisTransform.position,newPos,Time.time);
    }
}
