using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        Vector3 currentRotation = transform.rotation.eulerAngles;
        currentRotation.x = 0; // Låser x-rotationen till 0 grader
        transform.rotation = Quaternion.Euler(currentRotation);
    }

}
