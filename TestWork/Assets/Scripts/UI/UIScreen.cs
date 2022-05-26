using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScreen : MonoBehaviour
{
    [SerializeField] private ScreenType screenType;

    public ScreenType ScreenType { get => screenType; }
}
