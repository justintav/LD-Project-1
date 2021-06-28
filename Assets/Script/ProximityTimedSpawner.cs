using MoreMountains.CorgiEngine;
using UnityEngine;

public class ProximityTimedSpawner : TimedSpawner
{
    [SerializeField] float minimumDistance = 5f;
    GameObject player;

    protected override void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            return;
        }

        Vector3 playerPos = player.transform.position;
        playerPos.z = 0;
        Vector3 spawnerPos = transform.position;
        spawnerPos.z = 0;

        if (Vector3.Distance(playerPos, spawnerPos) > minimumDistance)
        {
            return;
        }

        base.Update();
    }
}
