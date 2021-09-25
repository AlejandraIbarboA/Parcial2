using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected readonly GameSystem gameSystem;

    public State(GameSystem system)
    {
        gameSystem = system;
    }

    public virtual IEnumerator Idle()
    {
        yield break;
    }

    public virtual IEnumerator Eat()
    {
        yield break;
    }

    public virtual IEnumerator Sleep()
    {
        yield break;
    }

    public virtual IEnumerator Sport()
    {
        yield break;
    }
}
