using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float trailDistance = 5.0f;
    public float heightOffset = 5.0f;
    public float cameraDelay = 0.005f;
    public float xRorrection = 0f;

    void FixedUpdate()
    {
        Vector3 followPos = target.position - target.forward * trailDistance;

        followPos.y += heightOffset;
        transform.position += ((followPos - transform.position) * 0.1f)  ;
        transform.position += xRorrection * (Quaternion.Euler(0, -90, 0) * target.forward);

        transform.LookAt(target.transform);
    }

}
