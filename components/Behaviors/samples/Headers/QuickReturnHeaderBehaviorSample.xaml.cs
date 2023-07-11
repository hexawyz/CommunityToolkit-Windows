// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CommunityToolkit.WinUI.Behaviors;

namespace BehaviorsExperiment.Samples;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
[ToolkitSample(id: nameof(QuickReturnHeaderBehaviorSample), nameof(QuickReturnHeaderBehavior), description: $"A sample for showing how to use the {nameof(QuickReturnHeaderBehavior)}.")]
public sealed partial class QuickReturnHeaderBehaviorSample : Page
{
    public QuickReturnHeaderBehaviorSample()
    {
        this.InitializeComponent();
    }
}
