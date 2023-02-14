using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    private bool gameHasended = false;
    public rotator Rotator;
    public Spawner _spawner;
    public Animator animator;
    public void EndGame()
    {
        if (gameHasended)
        {
            return;
        }

        Rotator.enabled = false;
        _spawner.enabled = false;
        animator.SetTrigger("EndGame");
        gameHasended = true;
    }
    
}
