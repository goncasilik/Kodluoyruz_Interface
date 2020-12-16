using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, ICollectable
{
    public void OnCollectable()
    {
        EventManager.OnBulletPickUpEvent.Invoke();
    }

    public void Use()
    {
        EventManager.OnBulletUseEvent.Invoke();
        Destroy(gameObject);
    }
}
