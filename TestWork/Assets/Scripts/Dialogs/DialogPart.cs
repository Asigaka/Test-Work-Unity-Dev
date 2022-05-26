using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DialogPart 
{
    [TextArea(1,5)]
    [SerializeField] private string characterText;
    [SerializeField] private List<PossibleAnswer> answers;

    public string CharacterText { get => characterText; }
    public List<PossibleAnswer> Answers { get => answers; }
}
