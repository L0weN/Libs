using UnityEngine;

public class JumpState : BaseState
{
    public JumpState(CharacterManager character) : base(character) { }

    public override void OnEnter()
    {
        Debug.Log("JumpState.OnEnter");
    }

    public override void OnExit()
    {
        Debug.Log("JumpState.OnExit");
    }
}
