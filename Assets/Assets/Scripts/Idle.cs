using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public IdleState(GameSystem gameSystem) : base(gameSystem)
    {
    }
    public override IEnumerator Idle()
    {
        Debug.Log("IDLE");
        yield break;
    }
}
