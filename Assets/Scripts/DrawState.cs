using UnityEngine;
using System.Collections;

using UnityEngine;

public class DrawState : GameStateBase
{
    public DrawState(GameManager gm) : base(gm) { }

    public override void Enter()
    {
        DeckManager.Instance.Draw(12);
        gm.ChangeState(new ActionState(gm));

    }
}

