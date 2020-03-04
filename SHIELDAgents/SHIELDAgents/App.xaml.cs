using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SHIELDAgents
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            AgentList.PopulateData();
            MainPage = new AgentsListPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
