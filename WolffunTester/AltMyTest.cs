using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;

namespace WolffunTester
{
    public class AltMyTest : DependencyObject
    {
        public ObservableCollection<AltMyTest> Children { get; } = new ObservableCollection<AltMyTest>();

        public AltMyTest()
        {

        }

        public bool Checked { get; set; }
        public string TestName { get; set; }

    }
}
