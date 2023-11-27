using UnityEngine;

public class DashState : BaseState
{
    public DashState(CharacterManager character) : base(character) { }

    public override void OnEnter()
    {
        Debug.Log("DashState.OnEnter");
    }

    public override void FixedUpdate()
    {
        Debug.Log("DashState.FixedUpdate");
    }

    public override void OnExit()
    {
        Debug.Log("DashState.OnExit");
    }
}
