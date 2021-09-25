using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    protected  GameSystem gameSystem;

    protected State(GameSystem gameSystem)
    {
        this.gameSystem = gameSystem;
    }

    public virtual IEnumerator Idle()
    {
        yield break;
    }
    public virtual IEnumerator Eat()
    {
        yield break;
    }
}
