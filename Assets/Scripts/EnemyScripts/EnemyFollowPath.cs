using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class EnemyFollowPath : Enemy
{

    public PathCreator pathCreator;
    [SerializeField]
    private PathCreation.EndOfPathInstruction _pathInstruction = PathCreation.EndOfPathInstruction.Reverse;
    [SerializeField]
    private float _speed = 3;
    [SerializeField]
    private float _distanceTraveled;

    // Update is called once per frame
    protected override void EnemyUpdate()
    {
        _distanceTraveled += _speed * Time.deltaTime;
        if (pathCreator == null)
        {
            Debug.Log($"path creator of {name} isnt set");
        }
        this.transform.position = pathCreator.path.GetPointAtDistance(_distanceTraveled, _pathInstruction);
        Vector3 dir = pathCreator.path.GetDirectionAtDistance(_distanceTraveled, _pathInstruction);
        float deg  = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(0.0f, 0.0f, deg);
    }
}
