using System;
using UnityEngine;


namespace VR {

    public class GameContext {

        // repo
        public RoleRepo roleRepo;
        // core 

        public AssetssCore assetsCore;
        public GameContext() {
            roleRepo = new RoleRepo();
            assetsCore = new AssetssCore();
        }

        public void Inject() { }
    }
}