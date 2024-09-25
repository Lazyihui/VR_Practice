using System;
using UnityEngine;


namespace VR {

    public class GameContext {

        public GameEntity gameEntity;

        // repo
        public RoleRepo roleRepo;
        // core 

        public AssetssCore assetsCore;

        public InputCore inputCore;

        public CameraCore cameraCore;
        public GameContext() {
            gameEntity = new GameEntity();

            roleRepo = new RoleRepo();


            assetsCore = new AssetssCore();
            inputCore = new InputCore();
            cameraCore = new CameraCore();
        }

        public void Inject(Camera camera) {
            cameraCore.Inject(camera);
        }

        public RoleEntity Role_GetOwner() {
            bool has = roleRepo.TryGet(gameEntity.roleOwnerID, out RoleEntity entity);
            if (!has) {
                Debug.LogError("GameContext.Role_GetOwner: roleOwnerID not found");
                return null;
            }
            return entity;
        }
    }
}