using System;
using UnityEngine;


namespace VR {


    public class RoleEntity : MonoBehaviour {
        public int id;

        public void Ctor() { }

        public void TearDown() { 
            Destroy(gameObject);
        }
    }
}
