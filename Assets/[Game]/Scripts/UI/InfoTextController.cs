using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTextController : MonoBehaviour
{
    private Text infoText;
    public Text InfoText { get { return (infoText == null) ? infoText = GetComponent<Text>() : infoText; } }

    public void WriteAppleInfoText()
    {
        InfoText.text = "E'ye basıp yersen canın dolar";
    }
    public void WriteBulletInfoText()
    {
        InfoText.text = "E'ye basıp toplarsan canın azalır";
    }
    public void WriteDoorInfoText()
    {
        InfoText.text = "E'ye basarsan kapı açılır";
    }

    private void OnEnable()
    {
        EventManager.OnApplePickUpEvent.AddListener(WriteAppleInfoText);
        EventManager.OnBulletPickUpEvent.AddListener(WriteBulletInfoText);
        EventManager.OnDoorOpenEvent.AddListener(WriteDoorInfoText);
    }
    private void OnDisable()
    {
        EventManager.OnApplePickUpEvent.RemoveListener(WriteAppleInfoText);
        EventManager.OnBulletPickUpEvent.RemoveListener(WriteBulletInfoText);
        EventManager.OnDoorOpenEvent.RemoveListener(WriteDoorInfoText);
    }
}
