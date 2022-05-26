using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogsView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI characterUIText;

    [Space]
    [SerializeField] private AnswerItem answerItemPrefab;
    [SerializeField] private Transform answersContent;

    public void UpdateDialogWindow(string characterText, List<PossibleAnswer> answers)
    {
        characterUIText.text = characterText;
        FillAnswers(answers);
    }

    private void FillAnswers(List<PossibleAnswer> answers)
    {
        for (int i = 0; i < answersContent.childCount; i++)
            Destroy(answersContent.GetChild(i).gameObject);

        foreach (PossibleAnswer answer in answers)
        {
            AnswerItem newAnswerItem = Instantiate(answerItemPrefab, answersContent);
            newAnswerItem.SetAnswer(answer);
        }
    }
}
