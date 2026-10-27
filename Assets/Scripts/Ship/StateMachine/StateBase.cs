using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBase : MonoBehaviour
{
    public virtual void OnStateEnter(object o = null)
    {
        Debug.Log("OnStateEnter");
    }

    public virtual void OnStateStray()
    {
        Debug.Log("OnStateStray");
    }

    public virtual void OnStateExit()
    {
        Debug.Log("OnStateExit");
    }
}

public class StateRunning : StateBase
{
    public Player player;

    public override void OnStateEnter(object o = null)
    {
        player = (Player)o;
        player.canMove = true;
        player.ChangeColor(Color.cyan);

        base.OnStateEnter(o);
    }

    public override void OnStateExit()
    {
        player.canMove = false;
        player.ChangeColor(Color.magenta);
        base.OnStateExit();
    }
}

public class StateDead : StateBase
{
    public override void OnStateEnter(object o = null)
    {
        base.OnStateEnter(o);

        Player player = (Player)o;
        player.ChangeColor(Color.yellow);
    }
}