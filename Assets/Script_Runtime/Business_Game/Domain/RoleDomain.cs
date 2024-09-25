using System;

using UnityEngine;

namespace VR {

    public static class RoleDomain {


        public static RoleEntity Spawn(GameContext ctx, int typeID, Vector3 pos) {
            GameObject prefab = ctx.assetsCore.Entity_GetRole();
            if (prefab == null) {
                Debug.LogError("RoleEntity prefab is null");
                return null;
            }

            GameObject go = GameObject.Instantiate(prefab, pos, Quaternion.identity);
            RoleEntity entity = go.GetComponent<RoleEntity>();

            entity.Ctor();

            ctx.roleRepo.Add(entity);

            return entity;
        }
    }


}