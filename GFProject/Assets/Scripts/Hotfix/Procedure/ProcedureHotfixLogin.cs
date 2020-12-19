using System;
using System.Collections;
using System.Collections.Generic;
using ETHotfix;
using GameFramework.Event;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Trinity.Hotfix
{
    public class ProcedureHotfixLogin : ProcedureBase
    {


        protected internal override void OnEnter(IFsm procedureOwner)
        {
            base.OnEnter(procedureOwner);

            Debug.Log("进入了登陆流程");
            GameEntry.Event.Subscribe(OpenUIFormSuccessEventArgs.EventId, OnOpenUIFormSuccess);
            GameEntry.UI.OpenUIForm(UIFormId.UILogin, this);

        }

        //protected internal override async void OnUpdate(IFsm procedureOwner, float elapseSeconds, float realElapseSeconds)
        //{
        //    base.OnUpdate(procedureOwner, elapseSeconds, realElapseSeconds);
        //    if (Input.GetKeyDown(KeyCode.A))
        //    {
        //        Session session = HotfixGameEntry.ETNetwork.CreateHotfixSession();
        //        session.Send(new HotfixTestMessage() { Info = "6666" });

        //        HotfixRpcResponse response = (HotfixRpcResponse)await session.Call(new HotfixRpcRequest() { Info = "Hello Server" });
        //        Debug.Log(response.Info);
        //        session.Dispose();
        //    }
        //}
        private void OnOpenUIFormSuccess(object sender, GameEventArgs e) {
            OpenUIFormSuccessEventArgs ne = (OpenUIFormSuccessEventArgs)e;
            if (ne.UserData != this) {
                return;
            }

            //(ne.UIForm.Logic as Trinity.HotfixUGuiForm).OnHotfixInit("UILogin", this);
        }

    }
}

