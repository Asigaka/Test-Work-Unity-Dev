using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class PossibleAnswer
{
    [SerializeField] private string answerText;
    public UnityEvent answersEvent;

    public string AnswerText { get => answerText; }
    public UnityEvent AnswersEvent { get => answersEvent; }
}
