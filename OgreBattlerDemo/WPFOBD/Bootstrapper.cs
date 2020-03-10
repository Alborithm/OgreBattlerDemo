using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using WPFOBD.ViewModels;

namespace WPFOBD
{
    // Video Example of implementation https://www.youtube.com/watch?v=p-fmOJMLl0A&list=PLLWMQd6PeGY0bEMxObA6dtYXuJOGfxSPx&index=6

    class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }

    }
}
