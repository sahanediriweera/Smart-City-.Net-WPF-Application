﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Testing_GUI_Project_DataBase.Database;

namespace Testing_GUI_Project_DataBase.FacilityUserControls.Transportation
{
    /// <summary>
    /// Interaction logic for Transportation.xaml
    /// </summary>
    public partial class Transportation : UserControl
    {
        public Transportation()
        {
            InitializeComponent();

            ListViewTransportation.ItemsSource = ModelTransportationData.trasportationItems;
        }
    }
}
