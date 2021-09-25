using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public IdleState(GameSystem _gameSystem) : base(_gameSystem)
    {
    }

    public override IEnumerator Idle()
    {
        Debug.Log("IDLE");
        yield return new WaitForSeconds(2f);
    }
}
