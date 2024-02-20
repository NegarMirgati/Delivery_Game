using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool has_package = false;
    [SerializeField] Color32 new_color = new Color32(42, 233, 19, 255);
    [SerializeField] Color32 old_color = new Color32(255, 251, 35, 255);

    SpriteRenderer SpriteRenderer;

    private void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("Ouch!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !has_package)
        {
            Debug.Log("You picked up the package!!!");
            has_package = true;
            SpriteRenderer.color = new_color;
            Destroy(other.gameObject, 0.2f);
        }
        if (other.tag == "Customer" && has_package == true)
        {
            Debug.Log("You delivered the package!!!");
            SpriteRenderer.color = old_color;
            has_package = false;

        }
    }
}
