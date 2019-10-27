using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CollisionData", menuName = "Data/CollisionData")]
public class CollisionData : Data
{
    public HashSet<Collision2D> collisions;

    public CollisionData()
    {
        collisions = new HashSet<Collision2D>();
    }

    public void Clear()
    {
       collisions.Clear();
    }
}
