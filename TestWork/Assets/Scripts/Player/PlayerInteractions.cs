using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] private LayerMask interLayer;
    [SerializeField] private float interRange;
    [SerializeField] private PlayerInteractionsView view;

    private Camera cam;
    private IInteractive currentInteractiveObj;

    private void Start()
    {
        cam = Camera.main;
        view.SetPingActiveState(false);
    }

    private void Update()
    {
        view.SetPingActiveState(CheckInteraction());

        if (Input.GetMouseButtonDown(0) && currentInteractiveObj != null)
        {
            currentInteractiveObj.OnInteract();
        }
    }

    private bool CheckInteraction()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;
        currentInteractiveObj = null;

        if (Physics.Raycast(ray, out hit, interRange, interLayer))
        {
            if (hit.collider)
            {
                IInteractive interactive = hit.collider.GetComponent<IInteractive>();

                if (interactive != null)
                {
                    currentInteractiveObj = interactive;
                    return true;
                }
            }
        }

        return false;
    }
}
