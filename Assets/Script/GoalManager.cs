using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public static GoalManager singleton;
    public int coinNeeded;
    public int coinCollected;
    public bool canEnter;

    private void Awake()
    {
        singleton = this;
    }

    public void CollectCoin()
    {
        coinCollected++;
        if (coinCollected >= coinNeeded)
        {
            canEnter = true;
        }
    }

}
