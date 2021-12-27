using UnityEngine;

public class dragonFollow : MonoBehaviour
{
    public Transform target;
    public float distance = 0.2f;
    public float speed  = 10f;

    void FixedUpdate()
    {
        transform.LookAt(target.transform);

        if (Vector3.Distance(target.position, transform.position) <= distance)
        {
            transform.position += transform.forward * 9.5f * Time.fixedDeltaTime;
        }
        else
        {
            transform.position += transform.forward * speed * Time.fixedDeltaTime;
        }
    }
}
