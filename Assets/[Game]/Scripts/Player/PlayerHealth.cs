using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public void IncreaseHealth()
    {
        Player player = FindObjectOfType<Player>();

        player.health += 1;

        EventManager.OnPlayerHealthChangeEvent.Invoke();

    }
    public void ReduceHealth()
    {
        Player player = FindObjectOfType<Player>();

        player.health -= 1;

        EventManager.OnPlayerHealthChangeEvent.Invoke();
    }

    private void OnEnable()
    {
        EventManager.OnAppleUseEvent.AddListener(IncreaseHealth);
        EventManager.OnBulletUseEvent.AddListener(ReduceHealth);

    }
    private void OnDisable()
    {
        EventManager.OnAppleUseEvent.RemoveListener(IncreaseHealth);
        EventManager.OnBulletUseEvent.RemoveListener(ReduceHealth);

    }
}
