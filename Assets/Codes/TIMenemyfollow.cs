using UnityEngine;
using System.Collections;

public class TIMenemyfollow : MonoBehaviour
{
    public int hp;
    public float speed = 20.0f;
    public float minDist = 1f;
    public Transform target;

    public float lockedYPosition = 0.0f;
    public float lockedXRotation = 0.0f;
    public float avoidanceRadius = 1.0f;
    public float avoidanceForce = 5.0f;

    // Use this for initialization
    void Start()
    {
        // if no target specified, assume the player
        if (target == null)
        {
            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Hämta nuvarande position
        Vector3 currentPosition = transform.position;
        // Sätt Y-position till den låsta positionen
        currentPosition.y = lockedYPosition;
        // Tilldela tillbaka den justerade positionen
        transform.position = currentPosition;

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, avoidanceRadius);
        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider != GetComponent<Collider>())
            {
                Vector3 direction = transform.position - hitCollider.transform.position;
                direction.y = 0;

                transform.position += direction.normalized * avoidanceForce * Time.deltaTime;
            }
        }

        if (target == null)
            return;

        // face the target
        transform.LookAt(target);

        // Lås X-rotationen
        Vector3 lockedRotation = transform.eulerAngles;
        lockedRotation.x = lockedXRotation;
        transform.eulerAngles = lockedRotation;

        //get the distance between the chaser and the target
        float distance = Vector3.Distance(transform.position, target.position);

        //so long as the chaser is farther away than the minimum distance, move towards it at rate speed.
        if (distance > minDist)
            transform.position += transform.forward * speed * Time.deltaTime;
    }

    // Set the target of the chaser
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}