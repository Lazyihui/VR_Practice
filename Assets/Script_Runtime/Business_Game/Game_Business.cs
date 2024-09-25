using System;
using UnityEngine;


namespace VR {
    public static class Game_Business {
        public static void Enter(GameContext ctx) {

            RoleDomain.Spawn(ctx, 1, new Vector3(0, 0, 0));
        }




        public static void Tick(GameContext ctx, float dt) {

            GameEntity game = ctx.gameEntity;

            // ProcessInput
            PreTick(ctx, dt);
            // DoLogic
            ref float restTime = ref game.restTime;

            restTime += dt;

            const float FIX_INTERVAL = 0.01f;

            if (restTime < FIX_INTERVAL) {
                FixTick(ctx, restTime);
                restTime = 0;
            } else {
                while (restTime >= FIX_INTERVAL) {
                    FixTick(ctx, FIX_INTERVAL);
                    restTime -= FIX_INTERVAL;
                }
            }

            LateTick(ctx, dt);


        }


        static void PreTick(GameContext ctx, float dt) {

        }

        static void FixTick(GameContext ctx, float dt) {
        }

        static void LateTick(GameContext ctx, float dt) {

        }

    }
}