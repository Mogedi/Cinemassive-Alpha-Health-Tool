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

namespace Alpha_Health
{
    public partial class ExceptionInfoUserControl : UserControl
    {
        List<string> uniqueSegmentsInstance;
        TextBox exceptionTextInstance;

        public ExceptionInfoUserControl()
        {
            InitializeComponent();
        }

        public void populateExceptionInstances(string exception, int frequency, TextBox exceptionText, List<string> uniqueSegments)
        {
            exceptionTextInstance = exceptionText;
            uniqueSegmentsInstance = uniqueSegments;
            textBlock.Text = exception;
            textBlock2.Text = "" + frequency + "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            exceptionTextInstance.Clear();
            foreach(string line in uniqueSegmentsInstance) {
                exceptionTextInstance.AppendText(line + "\n");
            }
        }
    }
}
