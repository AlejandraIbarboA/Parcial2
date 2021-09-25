using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : StateMachine
{
    private void Start()
    {
        SetState(new IdleState(this));
    }
    public void OnFeedButton()
    {
        StartCoroutine(State.Eat());
    }
    public void Idle()
    {
        StartCoroutine(State.Idle());
    }
}
