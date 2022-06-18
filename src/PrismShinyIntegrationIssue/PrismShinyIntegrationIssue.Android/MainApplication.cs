using Android.App;
using Android.Runtime;
using PrismShinyIntegrationIssue.IoC;
using Shiny;
using System;

namespace PrismShinyIntegrationIssue.Droid
{
    [Application(Theme = "@style/MainTheme")]
    public class MainApplication : Application
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            this.ShinyOnCreate(new Startup());
            Xamarin.Essentials.Platform.Init(this);
            base.OnCreate();
        }
    }
}