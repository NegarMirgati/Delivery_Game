using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float steer_speed = 300f;
    [SerializeField] float move_speed = 10f;
    void Start()
    {
    }
    void Update()
    {
        float steer_amount = Input.GetAxis("Horizontal");
        float move_amount = Input.GetAxis("Vertical");

        transform.Rotate(0, 0, -steer_amount * steer_speed * Time.deltaTime);
        transform.Translate(0, move_speed * move_amount * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "SpeedUp")
        {
            move_speed *= 2;
        }
        if (other.tag == "Bumper")
        {
            move_speed /= 2;
        }
    }
}
