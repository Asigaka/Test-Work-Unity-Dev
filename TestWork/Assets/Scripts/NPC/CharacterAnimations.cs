using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{
    [SerializeField] private string danceTrigger = "dance";
    [SerializeField] private string takeKickTrigger = "takeKick";
    [SerializeField] private Animator anim;

    public void TriggerDance()
    {
        anim.SetTrigger(danceTrigger);
    }

    public void TriggerTakeKick()
    {
        anim.SetTrigger(takeKickTrigger);
    }
}
