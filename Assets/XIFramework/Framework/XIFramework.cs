

using System;

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

    public interface ISendCommand : IGetArchitecture
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

    public interface IGetRegisterEvent
    {
        
    }
    #endregion

    #region Controller
    public interface IController :
        ISendCommand, IGetArchitecture, IGetModel, IGetUtility,
        IGetRegisterEvent,IGetSystem,IGetQuery,IGetContainer
    {

    }
    #endregion

    #region Model
    public interface IModel : IGetArchitecture , ISetArchiteture , ISendEvent, IGetUtility
    {
        
    }
    #endregion

    #region System
    public interface ISystem : IGetArchitecture, ISetArchiteture, IGetModel, IGetUtility,IGetSystem, IGetRegisterEvent,ISendEvent, IGetContainer
    {
        
    }
    #endregion

    #region Utility
    public interface IUtility
    {
        
    }
    #endregion

    #region Command
    public interface ICommand : ISetArchiteture, IGetArchitecture, ISendEvent, IGetRegisterEvent, IGetModel, IGetUtility
        ,IGetSystem, ISendCommand, IGetQuery, IGetContainer
    {
        void Execute();
    }

    public interface ICommand<TResult> : ISetArchiteture, IGetArchitecture, ISendEvent, IGetRegisterEvent, IGetModel, IGetUtility
        ,IGetSystem, ISendCommand, IGetQuery, IGetContainer
    {
        TResult Execute();
    }
    #endregion

    #region Query
    public interface IQuery<TResult> : IGetArchitecture, ISetArchiteture, IGetModel, IGetSystem, IGetQuery
    {
        TResult Seek();
    }
    #endregion


    public interface IGetArchitecture
    {
        IArchitecture GetArchitecture();
    }

    public interface ISetArchiteture
    {
        void SetArchitecture(IArchitecture architecture);
    }
    
    public abstract partial class Architecure<TCore> : IArchitecture, IDisposable where TCore : class, IArchitecture, new()
    {
        public void Dispose()
        {
        }
        public void Init()
        {
        }
        public void Completed()
        {
        }
        public void OnDestroy()
        {
        }
        public void UnRegisterModel<T>(T model = default) where T : class, IModel
        {
        }
        public void UnRegisterSystem<T>(T system = default) where T : class, ISystem
        {
        }
        public void UnRegisterUtility<T>(T utility = default) where T : class, IUtility
        {
        }
        public T GetModel<T>() where T : IModel
        {
            return default;
        }
        public T GetSystem<T>() where T : ISystem
        {
            return default;
        }
        public T GetUtility<T>() where T : IUtility
        {
            return default;
        }
        public void SendCommand<T>(T command) where T : ICommand
        {
        }
        public TResult SendCommand<TResult>(ICommand<TResult> command)
        {
            return default;
        }
        public TResult SendQuery<TResult>(IQuery<TResult> query)
        {
            return default;
        }
    }
}
