using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XIFramework
{
    public interface IArchitecture : IDisposable
    {
        void Init();
        void Completed();
        void OnDestroy();
        void UnRegisterModel<T>(T model = default) where T : class, IModel;
        void UnRegisterSystem<T>(T system = default) where T : class, ISystem;
        void UnRegisterUtility<T>(T utility = default) where T : class, IUtility;
        T GetModel<T>() where T : IModel;
        T GetSystem<T>() where T : ISystem;
        T GetUtility<T>() where T : IUtility;

        void SendCommand<T>(T command) where T : ICommand;

        TResult SendCommand<TResult>(ICommand<TResult> command);

        TResult SendQuery<TResult>(IQuery<TResult> query);

    }
    
    #region 层级规则
    public interface IGetModel : IGetArchitecture
    {
        
    }

    public interface IGetSystem : IGetArchitecture
    {
        
    }

    public interface IGetQuery : IGetArchitecture
    {
        
    }

    public interface IGetUtility : IGetArchitecture
    {
        
    }

    public interface IGetConfig : IGetArchitecture
    {
        
    }

    public interface IGetContainer : IGetArchitecture
    {
        
    }

    public interface ISendEvent
    {
        
    }

    public interface IGetRegiterEvent
    {
        
    }
    #endregion

    

    public interface IModel
    {
        
    }

    public interface ISystem
    {
        
    }

    public interface IUtility
    {
        
    }

    public interface ICommand
    {
        void Execute();
    }

    public interface ICommand<TResult>
    {
        TResult Execute();
    }

    public interface IQuery<TResult> : IGetArchitecture, ISetArchiteture
    {
        
    }

    public interface IGetArchitecture
    {
        IArchitecture GetArchitecture();
    }

    public interface ISetArchiteture
    {
        void SetArchitecture(IArchitecture architecture);
    }
}
