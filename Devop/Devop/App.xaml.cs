using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Devop
{
   public partial class App : Application
   {
      public App()
      {
         InitializeComponent();

         MainPage = new MainPage();
      }

      protected override void OnStart()
      {
         // Handle when your app start
         System.Diagnostics.Debug.WriteLine("test");
      }

      protected override void OnSleep()
      {
         // Handle when your app sleeps
      }

      protected override void OnResume()
      {
         // Handle when your app resumes
      }
   }
}
