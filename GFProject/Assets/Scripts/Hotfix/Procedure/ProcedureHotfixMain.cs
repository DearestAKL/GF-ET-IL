using System;
using System.Collections;
using System.Collections.Generic;
using ETHotfix;
using GameFramework.Event;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Trinity.Hotfix {
    public class ProcedureHotfixMain : ProcedureBase {


        protected internal override void OnEnter(IFsm procedureOwner) {
            base.OnEnter(procedureOwner);

            Debug.Log("进入了主界面流程 ");
        }

        protected internal override void OnUpdate(IFsm procedureOwner, float elapseSeconds, float realElapseSeconds) {
            base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
           
        }

    }
}
