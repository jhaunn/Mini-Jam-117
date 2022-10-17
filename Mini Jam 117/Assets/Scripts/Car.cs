using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour, IInteractable
{
    private bool isFinished = false;

    public string CheckDescription()
    {
        if (ScoreManager.instance.CheckFinish())
        {
            if (isFinished)
            {
                return "Preparing to quit";
            }

            return "Press E to leave";
        }
        else
        {
            return "WASD - Move | E - Interact";
        }
    }

    public string CheckName()
    {
        if (ScoreManager.instance.CheckFinish())
        {
            return "Thank you for playing!";
        }
        else 
        {
            return "Find and collect all your stuff";
        }
    }

    public void Interact()
    {
        if (ScoreManager.instance.CheckFinish() && !isFinished)
        {
            isFinished = true;
            SoundManager.instance.PlaySoundClip(3);
            Invoke("QuitGame", 5f);
        }
        else if (!isFinished)
        {
            SoundManager.instance.PlaySoundClip(0);
        }

    }

    private void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game has quit");
    }
}
