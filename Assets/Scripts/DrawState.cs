using UnityEngine;
using System.Collections;

using UnityEngine;

public class DrawState : GameStateBase
{
    public DrawState(GameManager gm) : base(gm) { }

    public override void Enter()
    {
        Debug.Log("ENTER: DrawState");

        // Later: gm.deckManager.Draw(3)
        // Nu: ga direct door naar ActionState:
        gm.ChangeState(new ActionState(gm));
    }
}

