﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private Necesities necesidades;
    //[SerializeField] private string stateString;
    [SerializeField] GameObject chargeBar;

    public Necesities Necesidades => necesidades;
    public GameObject ChargeBar => chargeBar;

    //public string StateString { get => stateString; set => stateString = value; }

    private State currentState;

    public void SetState(State _state)
    {
        currentState = _state;
        StartCoroutine(currentState.Idle());
    }

    private void Start()
    {
        necesidades = necesidades.GetComponent<Necesities>();
        SetState(new IdleState(this));
    }

    public void OnFeedButton()
    {
        //StateString = "food";
        SetState(new EatState(this));
        StartCoroutine(currentState.Eat());
    }

    public void OnSleepButton()
    {
        //StateString = "energy";
        SetState(new SleepState(this));
        StartCoroutine(currentState.Sleep());
    }

    public void OnSportButton()
    {
        SetState(new SportState(this));
        StartCoroutine(currentState.Sport());
    }
}