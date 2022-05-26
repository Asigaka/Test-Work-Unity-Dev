﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class AnswerItem : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private TextMeshProUGUI answerText;

    private PossibleAnswer answer;

    public void SetAnswer(PossibleAnswer answer)
    {
        this.answer = answer;
        answerText.text = answer.AnswerText;
    }

    private void OnAnswerClick()
    {
        DialogsController.Instance.ReplyInDialog(answer);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnAnswerClick();
    }
}
