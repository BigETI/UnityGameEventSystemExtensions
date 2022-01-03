using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "ObjectGameEvent", menuName = "Game events/System/Game event (Object)")]
    public class SystemObjectGameEventListenerObjectScript : AGameEventWithParameterObjectScript<System.Object>, ISystemObjectGameEventListenerObject
    {
        // ...
    }
}
