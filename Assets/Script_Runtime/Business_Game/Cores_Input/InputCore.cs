using System;
using UnityEngine;
using UnityEngine.XR;
using VR.InputInterval;


namespace VR {

    public class InputCore {
        InputCoreContext ctx;

        public InputCore() {
            ctx = new InputCoreContext();
            ctx.inputActions.Enable();
        }


        public void Tick(float dt) {

            Vector2 moveAxis = ctx.inputActions.Game.Move.ReadValue<Vector2>();
            ctx.rightHandl.moveAxis = moveAxis;
            Debug.Log("moveAxis:" + moveAxis);
            // 处理输入
            // if (Input.GetKey(KeyCode.W)) {
            //     moveAxis.y = 1;
            // } else if (Input.GetKey(KeyCode.S)) {
            //     moveAxis.y = -1;
            // }

            // if (Input.GetKey(KeyCode.A)) {
            //     moveAxis.x = -1;
            // } else if (Input.GetKey(KeyCode.D)) {
            //     moveAxis.x = 1;
            // }





            //  rotateAxis


        }

        public Vector2 GetMoveAxis() {
            return ctx.rightHandl.moveAxis;
        }

        public Vector2 GetRotateAxis() {
            return ctx.rightHandl.rotateAxis;
        }
    }
}