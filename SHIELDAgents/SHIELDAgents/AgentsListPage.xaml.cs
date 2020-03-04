using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SHIELDAgents
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgentsListPage : ContentPage
    {
        public AgentsListPage()
        {
            InitializeComponent();

            AgentsListView.ItemsSource = AgentList.Agents;
        }

        /// <summary>
        /// This method should be modified to navigate to a new page (AgentDetailsPage).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //You need to modify this method body to navigate to an AgentDetailsPage for additional details and edit functionality
            await DisplayAlert("S.H.I.E.L.D. Agent Tapped", "An agent was tapped, you're in trouble now.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        /// <summary>
        /// Do NOT modify this code.
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            AgentsListView.ItemsSource = AgentList.Agents;
        }
    }
}
