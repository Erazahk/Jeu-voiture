using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Move to Player", story: "[Move] to [Player] at [speed]", category: "Action", id: "573c0815939e66647c073f860517933f")]
public partial class MoveToPlayerAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Move;
    [SerializeReference] public BlackboardVariable<GameObject> Player;
    [SerializeReference] public BlackboardVariable<float> Speed;
    protected override Status OnStart()
    {
        return Status.Running;
    }

    protected override Status OnUpdate()
    {
        if((Move.Value.transform.position - Player.Value.transform.position).magnitude <= 4)
            return Status.Success;
        return Status.Failure;
    }

    protected override void OnEnd()
    {
    }
}