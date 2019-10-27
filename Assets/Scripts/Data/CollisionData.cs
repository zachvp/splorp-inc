using UnityEngine;

[CreateAssetMenu(fileName = "CollisionData", menuName = "Data/CollisionData")]
public class CollisionData : Data
{
    public Collision2D collision;

    public void Clear()
    {
       collision = null;
    }
}
