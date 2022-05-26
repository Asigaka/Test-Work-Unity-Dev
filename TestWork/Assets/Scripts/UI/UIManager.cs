using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ScreenType { HUD, Dialog}
public class UIManager : MonoBehaviour
{
    [SerializeField] private List<UIScreen> screens;

    private ScreenType currentScreenType;

    [HideInInspector] public UnityEvent OnScreenChange;
    public ScreenType CurrentScreenType { get => currentScreenType; }

    public static UIManager Instance;

    private void Awake()
    {
        if (Instance)
            Destroy(Instance);

        Instance = this;

        SwitchScreen(ScreenType.HUD);
    }

    public void SwitchScreen(ScreenType type)
    {
        currentScreenType = type;
        OnScreenChange.Invoke();

        foreach (UIScreen screen in screens)
        {
            screen.gameObject.SetActive(type == screen.ScreenType);
        }
    }
}
