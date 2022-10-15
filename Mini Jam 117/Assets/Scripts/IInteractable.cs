using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    string CheckName();
    string CheckDescription();
    void Interact();
}
