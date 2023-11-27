using Mert.FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState : IState
{
    protected CharacterManager character;
    protected BaseState(CharacterManager character)
    {
        this.character = character;
    }
    public virtual void OnEnter()
    {
        //
    }

    public virtual void Update()
    {
        //
    }

    public virtual void FixedUpdate()
    {
        //
    }

    public virtual void OnExit()
    {
        //
    }
}
