using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace VR {


    public class Main : MonoBehaviour {

        GameContext ctx;

        bool isInit = false;

        bool isTearDown = false;

        void Awake() {

            // == Ctor ==
            ctx = new GameContext();

            Camera maincam = Camera.main;
            //  == Injiect ==
            ctx.Inject(maincam);

            // == Load ==

            Action action = async () => {
                await ctx.assetsCore.LoadAll();
                isInit = true;

                //== Enter==
                Game_Business.Enter(ctx);

            };
            action.Invoke();
        }



        void Update() {
            if (!isInit) {
                return;
            }

            float dt = Time.deltaTime;

            Game_Business.Tick(ctx, dt);

        }

        void OnApplictionQuit() {
            TearDown();
        }

        void OnDestory() {
            TearDown();
        }

        void TearDown() {
            // 确保只运行一次
            if (isTearDown) {
                return;
            }
            isTearDown = true;

            ctx.assetsCore.UnloadAll();
        }
    }
}
