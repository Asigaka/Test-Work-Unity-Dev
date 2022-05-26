using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogContainer : MonoBehaviour
{
    [SerializeField] private DialogPart dialog;

    public DialogPart Dialog { get => dialog; }
}
