﻿#pragma checksum "D:\GitHub\Events\Microsoft Tech Summit 2016\Samples\Orbit 3D\Launchers\UWPProfile\Views\PlanetsView.DeviceFamily-Xbox.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1AE69657C1916EFE2991026D2E164682"
#pragma checksum "D:\GitHub\Events\Microsoft Tech Summit 2016\Samples\Orbit 3D\Launchers\UWPProfile\Views\PlanetsView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E51265A0BF1E96AC4FD115ABE7457014"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orbit.Views
{
    partial class PlanetsView : global::Orbit.Views.Base.PageBase
    {


        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid RootElement; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Orbit.Controls.Timeline Timeline; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView ItemListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            this.InitializeComponent(null);
        }

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent(global::System.Uri resourceLocator)
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            if (resourceLocator == null)
            {
                resourceLocator = new global::System.Uri("ms-appx:///Views/PlanetsView.xaml");
            }
            global::Windows.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

        private interface IPlanetsView_Bindings
        {
            void Initialize();
            void Update();
            void StopTracking();
        }
#pragma warning disable 0169    //  Proactively suppress unused field warning in case Bindings is not used.
        private IPlanetsView_Bindings Bindings;
#pragma warning restore 0169
    }
}


