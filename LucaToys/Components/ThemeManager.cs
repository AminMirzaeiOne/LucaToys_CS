using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucaToys.Components
{
    public partial class ThemeManager : Component
    {
        public ThemeManager()
        {
            InitializeComponent();
        }

        public ThemeManager(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
