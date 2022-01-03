using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "AttributeGameEvent", menuName = "Game events/System/Game event (Attribute)")]
    public class SystemAttributeGameEventListenerObjectScript : AGameEventWithParameterObjectScript<Attribute>, ISystemAttributeGameEventListenerObject
    {
        // ...
    }
}
