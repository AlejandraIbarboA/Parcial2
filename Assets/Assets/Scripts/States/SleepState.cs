using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepState : State
{
    public SleepState(GameSystem _gameSystem) : base(_gameSystem)
    {
    }

    public override IEnumerator Sleep()
    {
        gameSystem.Necesidades.ModifyNecesities("energy", 3);
        gameSystem.Sound.clip = gameSystem.Sleepaudio;
        gameSystem.Sound.Play();
        Debug.Log("Sleeping");
        gameSystem.ChargeBar.SetActive(true);
        yield return new WaitForSeconds(2f);
        gameSystem.ChargeBar.SetActive(false);
        // gameSystem.StateString = "";
        gameSystem.SetState(new IdleState(gameSystem));
    }
}
