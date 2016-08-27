using StructureMap;
using StructureMap.Graph;
using StructureMap.Pipeline;
using System;
using System.Web.Mvc;

namespace Web.DependencyResolution
{
    public class ControllerConvention : IRegistrationConvention
    {
        #region Public Methods and Operators

        public void Process(Type type, Registry registry)
        {
            if (type.CanBeCastTo<Controller>() && !type.IsAbstract)
            {
                registry.For(type).LifecycleIs(new UniquePerRequestLifecycle());
            }
        }

        #endregion Public Methods and Operators
    }
}