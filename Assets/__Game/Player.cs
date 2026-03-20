using System;
using System.Collections;
using System.Collections.Generic;

using System.Runtime.CompilerServices;

using System.Diagnostics.CodeAnalysis;

using UnityEngine;


namespace SpaceDefender.Core
{
    public sealed class Player
    {
        public int Health { get; private set; } = 100;
        public int Lives { get; private set; } = 3;
        public int Score { get; private set; } = 0;

        public bool IsAlive => Health > 0 && Lives > 0;

        public void TakeDamage(int amount)
        {
            if (amount <=  0)
                return;

            Health = Mathf.Max(0, Health - amount);
        }


        public void Heal(int amount)
        {
            if (amount <= 0)
                return;

            Health = Mathf.Min(Health + amount, 100);
        }
        public void AddScore(int points) => Score += points;
        public void LoseLife()
        {
            if (Lives <= 0)
                return;

            Lives--;
        }
    }

    

    
}
