using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour, ICollectable
{
    public void OnCollectable()
    {
        EventManager.OnApplePickUpEvent.Invoke();
    }

    public void Use()
    {
        EventManager.OnAppleUseEvent.Invoke();
        Destroy(gameObject);
    }
}
