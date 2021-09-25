using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportState : State
{
    public SportState(GameSystem _gameSystem) : base(_gameSystem)
    {
    }

    public override IEnumerator Sport()
    {
        gameSystem.Necesidades.ModifyNecesities("food", -1);
        gameSystem.Necesidades.ModifyNecesities("energy",-1);
        Debug.Log("Sporting");
        gameSystem.ChargeBar.SetActive(true);
        yield return new WaitForSeconds(2f);
        gameSystem.ChargeBar.SetActive(false);
        //gameSystem.StateString = "";
        gameSystem.SetState(new IdleState(gameSystem));
    }
}
