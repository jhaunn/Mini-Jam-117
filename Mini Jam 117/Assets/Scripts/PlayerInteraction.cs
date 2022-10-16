using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private LayerMask interactableLayerMask;
    [SerializeField] private float interactDistance = 2f;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI descriptionText;

    void Update()
    {
        RaycastHit hit;
        IInteractable hitInteractable;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, interactDistance, interactableLayerMask) &&
            hit.collider.GetComponent<IInteractable>() != null)
        {
            hitInteractable = hit.collider.gameObject.GetComponent<IInteractable>();
            SetCursorText(hitInteractable.CheckName(), hitInteractable.CheckDescription());

            if (Input.GetKeyDown(KeyCode.E))
            {
                hitInteractable.Interact();
            }
        }
        else
        {
            ResetCursorText();
        }
    }

    void SetCursorText(string name, string desc)
    {
        nameText.text = name;
        descriptionText.text = desc;
    }

    void ResetCursorText()
    {
        nameText.text = "";
        descriptionText.text = "";
    }
}
