using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "SeekPlayer", story: "Agent seeks Player at [speed]", category: "Action", id: "1381a31ac3fdef62a3a096a3775f3f86")]
public partial class SeekPlayerAction : Action
{
    [SerializeReference] public BlackboardVariable<float> Speed;
    private Transform player;
    private Transform self;

    protected override Status OnStart() // Called when the node starts executing
    {
        player = PlayerController.instance.transform;
        self = GameObject.transform;

        if (player == null)
        {
            Debug.Log("Player not found!");
            return Status.Failure;
        }
        else
        {
            Debug.Log("Player found! Starting to seek...");
            return Status.Running;
        }
    }

    protected override Status OnUpdate() // Called every frame while the node is running
    {
        if (player == null)
        {
            return Status.Failure;
        }

        Vector3 direction = (player.position - self.position).normalized;
        self.position += direction * Speed * Time.deltaTime;

        return Status.Running;
    }

    protected override void OnEnd() // Called when the node finishes executing (either success or failure)
    {
    }
}

