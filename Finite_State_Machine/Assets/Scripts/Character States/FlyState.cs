using UnityEngine;

public class FlyState : BaseState
{
    public FlyState(CharacterManager character) : base(character) { }

    public override void OnEnter()
    {
        Debug.Log("FlyState.OnEnter");
    }

    public override void Update()
    {
        Debug.Log("FlyState.Update");
    }

    public override void OnExit()
    {
        Debug.Log("FlyState.OnExit");
    }
}
