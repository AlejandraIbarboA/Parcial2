using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatState : State
{
    public EatState(GameSystem _gameSystem) : base(_gameSystem)
    {
    }

    public override IEnumerator Eat()
    {
        gameSystem.Necesidades.ModifyNecesities("food", 2);
        gameSystem.Sound.clip = gameSystem.Eataudio;
        gameSystem.Sound.Play();
        Debug.Log("Eating");
        gameSystem.ChargeBar.SetActive(true);
        yield return new WaitForSeconds(2f);
        gameSystem.ChargeBar.SetActive(false);
        //gameSystem.StateString = "";
        gameSystem.SetState(new IdleState(gameSystem));
    }
}
