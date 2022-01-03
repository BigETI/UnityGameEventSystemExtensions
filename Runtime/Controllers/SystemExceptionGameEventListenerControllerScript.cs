using System;
using UnityGameEvents.Controllers;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions.Controllers
{
    public class SystemExceptionGameEventListenerControllerScript : AGameEventWithParameterListenerControllerScript<SystemExceptionGameEventListenerObjectScript, Exception>, ISystemExceptionGameEventListenerController
    {
        // ...
    }
}
