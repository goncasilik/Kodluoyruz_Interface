using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int moveSpeed;

    public int health = 0;

    private Rigidbody rigidbody;
    public Rigidbody Rigidbody { get { return (rigidbody == null) ? rigidbody = GetComponent<Rigidbody>() : rigidbody; } }

    public GameObject nearestGameObject = null;

    private void Update()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Rigidbody.velocity = input * moveSpeed * Time.fixedDeltaTime;

        if (Input.GetKeyDown(KeyCode.E))
        {
            ICollectable collectable = nearestGameObject.GetComponent<ICollectable>();
            if (collectable != null)
            {
                collectable.Use();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ICollectable collectable = other.GetComponent<ICollectable>();

        nearestGameObject = other.gameObject;

        if (collectable != null)
        {
            collectable.OnCollectable();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        nearestGameObject = null;
    }
}
