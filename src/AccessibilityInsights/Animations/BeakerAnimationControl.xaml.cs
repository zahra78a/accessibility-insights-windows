// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using AccessibilityInsights.CommonUxComponents.Controls;
using System.Windows.Automation.Peers;
using System.Windows.Controls;


namespace AccessibilityInsights.Animations
{
    /// <summary>
    /// Interaction logic for BeakerAnimationControl.xaml
    /// </summary>
    public partial class BeakerAnimationControl : UserControl
    {
        public BeakerAnimationControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overriding LocalizedControlType
        /// </summary>
        /// <returns></returns>
        protected override AutomationPeer OnCreateAutomationPeer() => new CustomControlOverridingAutomationPeer(this, "animation");
    }
}
