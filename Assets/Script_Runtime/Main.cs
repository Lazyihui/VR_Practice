using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace VR {


    public class Main : MonoBehaviour {

        GameContext ctx;

        bool isInit = false;

        bool isTearDown = false;

        void Awake() {

            // == Ctor ==
            ctx = new GameContext();
            //  == Injiect ==
            ctx.Inject();

            // == Load ==

            Action action = async () => {
                await ctx.assetsCore.LoadAll();
                isInit = true;

                //== Enter==

            };
            action.Invoke();
        }



        void Update() {

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
