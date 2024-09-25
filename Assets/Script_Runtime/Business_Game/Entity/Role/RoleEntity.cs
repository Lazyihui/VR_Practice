using System;
using UnityEngine;


namespace VR {


    public class RoleEntity : MonoBehaviour {
        public int id;

        public RoleInputComponent roleInputComponent;

        public void Ctor() {
            roleInputComponent = new RoleInputComponent();
        }

        public void TearDown() {
            Destroy(gameObject);
        }
    }
}
