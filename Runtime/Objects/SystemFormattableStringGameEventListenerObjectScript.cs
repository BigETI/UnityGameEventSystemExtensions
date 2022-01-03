using System;
using UnityEngine;
using UnityGameEvents.Objects;

namespace UnityGameEventSystemExtensions.Objects
{
    [CreateAssetMenu(fileName = "FormattableStringGameEvent", menuName = "Game events/System/Game event (FormattableString)")]
    public class SystemFormattableStringGameEventListenerObjectScript : AGameEventWithParameterObjectScript<FormattableString>, ISystemFormattableStringGameEventListenerObject
    {
        // ...
    }
}
