using System;
using UnityGameEvents.Controllers;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions.Controllers
{
    public class SystemDateTimeGameEventListenerControllerScript : AGameEventWithParameterListenerControllerScript<SystemDateTimeGameEventListenerObjectScript, DateTime>, ISystemDateTimeGameEventListenerController
    {
        // ...
    }
}
