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
    /// <summary>
    /// Interaction logic for LogInfoUserControl1.xaml
    /// </summary>
    public partial class LogInfoUserControl : UserControl
    {
        public LogInfoUserControl()
        {
            InitializeComponent();
        }

        public void addExceptionInstance()
        {
            ExceptionInfoUserControl exceptionInfo = new ExceptionInfoUserControl();

            exceptionStackPanel.Children.Add(exceptionInfo);
        }
    }
}
