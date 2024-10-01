using System;
using UnityEngine;
using UnityEngine.XR;
using VR.InputInterval;
using UnityEngine.InputSystem;


namespace VR {

    public class InputCore {
        InputCoreContext ctx;

        public InputCore() {
            ctx = new InputCoreContext();
            ctx.inputActions.Enable();
        }


        public void Tick(float dt) {

            {
                // moveAxis
                Vector2 moveAxis = ctx.inputActions.Game.Move.ReadValue<Vector2>();
                ctx.rightHandl.moveAxis = moveAxis;
                // 处理输入
            }

            {
                //  rotateAxis
                Quaternion quat = ctx.inputActions.Game.Rotate.ReadValue<Quaternion>();
                
                Vector3 fwd = quat * Vector3.forward;

                // Vector2 rotateAxis = ctx.inputActions.Game.Rotate.ReadValue<Vector2>();

                // ctx.rightHandl.rotateAxis = rotateAxis;
            }
            // 按下中键
            {
                
            }


        }

        public Vector2 GetMoveAxis() {
            return ctx.rightHandl.moveAxis;
        }

        public Vector2 GetRotateAxis() {
            return ctx.rightHandl.rotateAxis;
        }
    }
}