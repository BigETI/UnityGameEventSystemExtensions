using System;
using UnityGameEvents.Controllers;
using UnityGameEventSystemExtensions.Objects;

namespace UnityGameEventSystemExtensions.Controllers
{
    public class SystemGuidGameEventListenerControllerScript : AGameEventWithParameterListenerControllerScript<SystemGuidGameEventListenerObjectScript, Guid>, ISystemGuidGameEventListenerController
    {
        // ...
    }
}
