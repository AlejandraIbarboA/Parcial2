using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private Necesities necesidades;
    [SerializeField] GameObject chargeBar;

    public Necesities Necesidades => necesidades;
    public GameObject ChargeBar => chargeBar;

    private State currentState;

    [SerializeField] AudioClip sportSound;
    [SerializeField] AudioClip eatSound;
    [SerializeField] AudioClip sleepSound;
    private AudioSource sound;

    public AudioClip SportSound => sportSound;
    public AudioClip EatSound => eatSound;
    public AudioClip SleepSound => sleepSound;

    public AudioSource Sound => sound;

    public void SetState(State _state)
    {
        currentState = _state;
        StartCoroutine(currentState.Idle());
    }

    private void Start()
    {
        sound = GetComponent<AudioSource>();
        necesidades = necesidades.GetComponent<Necesities>();

        SetState(new IdleState(this));
    }

    public void OnFeedButton()
    {
        SetState(new EatState(this));
        StartCoroutine(currentState.Eat());
    }

    public void OnSleepButton()
    {
        SetState(new SleepState(this));
        StartCoroutine(currentState.Sleep());
    }

    public void OnSportButton()
    {
        SetState(new SportState(this));
        StartCoroutine(currentState.Sport());
    }
}
