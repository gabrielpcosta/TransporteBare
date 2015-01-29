using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ManausBus
{
    public sealed partial class SearchDialogueBox : UserControl
    {
        public class BusIdentification {
            public string BusNumber { get; set; }
        }

        private List<BusIdentification> busId = new List<BusIdentification>();

        public SearchDialogueBox()
        {
            #region TesteEstático
            busId.Add(new BusIdentification() {
                BusNumber = "200"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "201"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "202"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "203"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "204"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "205"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "206"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "207"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "208"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "209"
            });
            busId.Add(new BusIdentification() {
                BusNumber = "210"
            });
            #endregion
            
            this.InitializeComponent();

            grdBus.ItemsSource = busId;
        }

        private void grdBus_ItemClick(object sender, ItemClickEventArgs e)
        {
            BusIdentification o = (BusIdentification) e.ClickedItem;
            new MessageDialog(o.BusNumber,e.ClickedItem.ToString()).ShowAsync();
        }

    }
}
