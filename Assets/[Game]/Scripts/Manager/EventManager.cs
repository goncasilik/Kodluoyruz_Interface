using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static UnityEvent OnApplePickUpEvent = new UnityEvent();
    public static UnityEvent OnBulletPickUpEvent = new UnityEvent();
    public static UnityEvent OnDoorOpenEvent = new UnityEvent();
    public static UnityEvent OnAppleUseEvent = new UnityEvent();
    public static UnityEvent OnBulletUseEvent = new UnityEvent();
    public static UnityEvent OnPlayerHealthChangeEvent = new UnityEvent();



}
