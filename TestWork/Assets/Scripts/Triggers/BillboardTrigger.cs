using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardTrigger : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void Awake()
    {
        rb.isKinematic = true;
    }

    public void Drop()
    {
        rb.isKinematic = false;
    }
}
