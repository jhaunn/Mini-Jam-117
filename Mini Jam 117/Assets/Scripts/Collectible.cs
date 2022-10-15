using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collectible : MonoBehaviour, IInteractable
{
    [SerializeField] private new string name;
    [SerializeField] private string description;

    public string CheckDescription()
    {
        return description;
    }

    public string CheckName()
    {
        return name;
    }
    public void Interact()
    {
        Debug.Log($"Interacted with {name}");
        gameObject.SetActive(false);
    }
}