using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "AttackPlayer", story: "[Agent] attacks [player]", category: "Action", id: "52076032da5e42198954ccf76a10ef61")]
public partial class AttackPlayerAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Agent;
    [SerializeReference] public BlackboardVariable<GameObject> Player;

    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if((Agent.Value.transform.position - Player.Value.transform.position).magnitude >= 4)
            return Status.Failure;
        Attack(Player.Value.GetComponent<Car>());
        return Status.Success;
    }

    void Attack(Car playerToAttack)
    {
        playerToAttack.HP--;
    }

    protected override void OnEnd()
    {
    }
}

