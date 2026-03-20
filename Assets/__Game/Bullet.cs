using UnityEngine;

namespace SpaceDefender.Core
{
    public sealed class Bullet
    {
        public float Speed;
        public int Damage;
        public bool IsActive;
        public Vector2 Position;
        public void Move(float deltaTime) => throw new System.NotImplementedException();
        public bool CheckCollision(Enemy enemy) => throw new System.NotImplementedException();
        public void Deactivate() => IsActive = false;
    }
}