using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractionsView : MonoBehaviour
{
    [SerializeField] private GameObject interactionPing;

    public void SetPingActiveState(bool state)
    {
        interactionPing.SetActive(state);
    }
}
