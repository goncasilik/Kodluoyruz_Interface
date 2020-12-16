using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextController : MonoBehaviour
{
    private Text healthText;
    public Text HealthText { get { return (healthText == null) ? healthText = GetComponent<Text>() : healthText; } }

    public void WriteIncreaseHealthText()
    {
        Player player = FindObjectOfType<Player>();
        HealthText.text = "Health: " + player.health;
    }
    private void OnEnable()
    {
        EventManager.OnPlayerHealthChangeEvent.AddListener(WriteIncreaseHealthText);
    }
    private void OnDisable()
    {
        EventManager.OnPlayerHealthChangeEvent.RemoveListener(WriteIncreaseHealthText);
    }
}
