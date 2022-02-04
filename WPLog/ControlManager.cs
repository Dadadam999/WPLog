using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPLog
{
    public static class ControlManager
    {
        private static Panel _panelOut;
        private static List<UserControl> _controls = new List<UserControl>();

        public static void SetOutput( Panel panelOut ) => _panelOut = panelOut;
        public static void ShowControl( string name ) => _controls.ForEach( uc => { uc.Visible = uc.Name == name; } );
        public static UserControl[] GetControls() => _controls.ToArray();

        public static void InitControl( UserControl control, string name )
        {
            control.Dock = DockStyle.Fill;
            control.Visible = false;
            control.Name = name;
            _controls.Add( control );
            _panelOut.Controls.Add( control );
        }
    }
}