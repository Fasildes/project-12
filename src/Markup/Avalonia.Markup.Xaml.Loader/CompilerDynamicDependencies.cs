﻿using System;
using System.Diagnostics.CodeAnalysis;

// WARNING: this is a partial class, second part of which is generated by CompilerDynamicDependenciesGenerator.

namespace Avalonia.Markup.Xaml.XamlIl;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
internal sealed partial class CompilerDynamicDependenciesAttribute : Attribute
{
    public const DynamicallyAccessedMemberTypes XamlDynamicallyAccessedMemberTypes = DynamicallyAccessedMemberTypes.All ^
        (DynamicallyAccessedMemberTypes.NonPublicConstructors
         | DynamicallyAccessedMemberTypes.NonPublicEvents
         | DynamicallyAccessedMemberTypes.NonPublicFields
         | DynamicallyAccessedMemberTypes.NonPublicMethods
         | DynamicallyAccessedMemberTypes.NonPublicProperties
         | DynamicallyAccessedMemberTypes.NonPublicNestedTypes);
}
