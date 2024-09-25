using System;
using UnityEngine;


namespace VR {

    public class GameContext {

        public GameEntity gameEntity;

        // repo
        public RoleRepo roleRepo;
        // core 

        public AssetssCore assetsCore;
        public GameContext() {
            gameEntity = new GameEntity();

            roleRepo = new RoleRepo();
            assetsCore = new AssetssCore();
        }

        public void Inject() { }
    }
}