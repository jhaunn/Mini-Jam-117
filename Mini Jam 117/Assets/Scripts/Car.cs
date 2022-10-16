using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour, IInteractable
{
    public string CheckDescription()
    {
        if (ScoreManager.instance.CheckFinish())
        {
            return "Press E to leave";
        }
        else
        {
            return "???";
        }
    }

    public string CheckName()
    {
        if (ScoreManager.instance.CheckFinish())
        {
            return "";
        }
        else 
        {
        return "Get all your stuff";
        }
    }

    public void Interact()
    {
        if (ScoreManager.instance.CheckFinish())
        {
            Debug.Log("Game is finished");
        }
        else
        {
            Debug.Log("Gather all collectibles");
        }
    }
}
