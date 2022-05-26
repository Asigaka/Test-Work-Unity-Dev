using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogsController : MonoBehaviour
{
    [SerializeField] private DialogsView view;

    public static DialogsController Instance;

    private void Awake()
    {
        if (Instance)
            Destroy(Instance);

        Instance = this;
    }

    public void StartDialog(DialogContainer dialog)
    {
        UIManager.Instance.SwitchScreen(ScreenType.Dialog);
        view.UpdateDialogWindow(dialog.Dialog.CharacterText, dialog.Dialog.Answers);
    }

    public void ReplyInDialog(PossibleAnswer answer)
    {
        UIManager.Instance.SwitchScreen(ScreenType.HUD);
        answer.AnswersEvent.Invoke();
    }
}
