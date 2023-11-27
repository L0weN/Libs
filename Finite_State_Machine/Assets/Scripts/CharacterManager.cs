using Mert.FSM;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [Header("State Machine")]
    protected StateMachine stateMachine;

    [Header("States")]
    protected DashState dashState;
    protected JumpState jumpState;
    protected FlyState flyState;
    protected virtual void Awake()
    {
        stateMachine = new StateMachine();

        dashState = new DashState(this);
        jumpState = new JumpState(this);
        flyState = new FlyState(this);

        At(flyState, dashState, new FuncPredicate(() => Input.GetKeyDown(KeyCode.D)));
        At(flyState, jumpState, new FuncPredicate(() => Input.GetKeyDown(KeyCode.J)));
        Any(flyState, new FuncPredicate(() => Input.GetKeyDown(KeyCode.F)));

        stateMachine.SetState(flyState);
    }

    protected virtual void Update()
    {
        stateMachine.Update();
    }

    protected virtual void FixedUpdate()
    {
        stateMachine.FixedUpdate();
    }

    protected void At(IState from, IState to, IPredicate condition) => stateMachine.AddTransition(from, to, condition);
    protected void Any(IState to, IPredicate condition) => stateMachine.AddAnyTransition(to, condition);
}
