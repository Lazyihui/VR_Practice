using System;
using UnityEngine;



namespace VR.InputInterval {
    public class InputCoreContext{
        public InputEntity rightHandl;


        public InputCoreContext() {
            rightHandl = new InputEntity();
            rightHandl.id = 1;
        
        }
    }
}