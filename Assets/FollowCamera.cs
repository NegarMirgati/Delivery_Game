using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // The camera's position should be the same as the car's position
    [SerializeField] GameObject followee;
    void Update()
    {
        // transform.position = followee.transform.position + new Vector3(0f, 0f, -20f);
    }
    void LateUpdate()
    {
        transform.position = followee.transform.position + new Vector3(0f, 0f, -20f);
    }
}
