using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatState : State
{
    public EatState(GameSystem gameSystem) : base(gameSystem)
    {
    }

    public override IEnumerator Eat()
    {
        Debug.Log("Eating");
        yield return new WaitForSeconds(1f);
        gameSystem.SetState(new IdleState(gameSystem));
    }
}
