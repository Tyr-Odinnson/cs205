﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDown
{
    class Player
    {
        public Player(Vector2 _position)
        {
            Position = _position;
            maxHP = hp;
        }

        public static Vector2 Position;

        public int hp = 10;

        private string log = "";
        private int maxHP;
        private int potions = 1;

        public void Act()
        {

        }

        public void Log()
        {

        }

        private bool CollideCactus()
        {
            return false;
        }

        private bool CollideEnemy()
        {
            return false;
        }

        private bool CollidePotion(ref char _c)
        {
            return false;
        }

        private bool CollideRock()
        {
            return false;
        }

        private bool HandleObstruction(ref char _c)
        {
            return false;
        }

        private bool IsObstructed(Vector2 _direction)
        {
            return false;
        }

        private Vector2 GetInputDirection()
        {
            return Vector2.Zero;
        }

        private void UsePotion()
        {

        }

    }
}
