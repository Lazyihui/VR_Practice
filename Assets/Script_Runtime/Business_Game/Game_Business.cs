using System;
using UnityEngine;


namespace VR {
    public static class Game_Business {
        public static void Enter(GameContext ctx) {

            RoleDomain.Spawn(ctx, 1, new Vector3(0, 0, 0));
        }




        public static void Tick() { }

    }
}