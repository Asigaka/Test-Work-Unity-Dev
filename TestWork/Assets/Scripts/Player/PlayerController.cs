using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerMovement movement;
    [SerializeField] private MouseLook look;
    [SerializeField] private PlayerInteractions interactions;

    private UIManager uiManager;

    private void Start()
    {
        uiManager = UIManager.Instance;
        uiManager.OnScreenChange.AddListener(OnScreenSwitchActiveStateChange);
    }

    //Наверное, название длинное?:0
    private void OnScreenSwitchActiveStateChange()
    {
        movement.enabled = uiManager.CurrentScreenType == ScreenType.HUD;
        look.enabled = uiManager.CurrentScreenType == ScreenType.HUD;
        interactions.enabled = uiManager.CurrentScreenType == ScreenType.HUD;
    }
}
