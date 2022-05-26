using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour, IInteractive
{
    [SerializeField] private DialogContainer characterDialog;

    public DialogContainer CharacterDialog { get => characterDialog; }

    public void OnInteract()
    {
        DialogsController.Instance.StartDialog(characterDialog);
    }
}
