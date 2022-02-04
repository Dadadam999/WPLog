using BunifuAnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPLog
{
    public partial class Main : Form
    {
        [DllImport( "user32.DLL", EntryPoint = "ReleaseCapture" )]
        private extern static void ReleaseCapture();
        [DllImport( "user32.DLL", EntryPoint = "SendMessage" )]
        private extern static void SendMessage( IntPtr hWnd, int wMsg, int wParam, int lParam );

        private bool _resizerEnable = false;

        public Main()
        {
            InitializeComponent();

            SetSizeContainer();

            ControlManager.SetOutput( _workSpaceContainer );
            ControlManager.InitControl( new HomeView(), "HomeView" );
            ControlManager.InitControl( new MonitorView(), "MonitorView" );
            ControlManager.InitControl( new SettingsView(), "SettingsView" );
            ControlManager.InitControl( new AboutView(), "AboutView" );
            ControlManager.InitControl( new DonateView(), "DonateView" );
            ControlManager.ShowControl( "HomeView" );
        }

        private void MoveFormMouseDown( object sender, MouseEventArgs e )
        {
            ReleaseCapture();
            SendMessage( Handle, 0x112, 0xf012, 0 );
        }

        private void SetSizeContainer()
        {
            int borderSize = 2;

            _borderRight.Width = borderSize;
            _borderDown.Height = borderSize;
            _borderAngle.Width = borderSize;
        }

        private void ClickFromExit( object sender, EventArgs e ) => Application.Exit();

        private void ClickFromMaximum( object sender, EventArgs e ) => WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;

        private void ClickFromTray( object sender, EventArgs e ) => WindowState = FormWindowState.Minimized;

        private void HomeBtnClick( object sender, EventArgs e ) => ControlManager.ShowControl( "HomeView" );

        private void MonitorBtnClick( object sender, EventArgs e ) => ControlManager.ShowControl( "MonitorView" );

        private void SettingsBtnClick( object sender, EventArgs e ) => ControlManager.ShowControl( "SettingsView" );

        private void AboutBtnClick( object sender, EventArgs e ) => ControlManager.ShowControl( "AboutView" );

        private void DonateBtnClick( object sender, EventArgs e ) => ControlManager.ShowControl( "DonateView" );

        private void ResizeFormMouseDown( object sender, MouseEventArgs e ) => _resizerEnable = true;

        private void ResizeFormMouseUp( object sender, MouseEventArgs e ) => _resizerEnable = false;

        private void ResizeFormMouseMove( object sender, MouseEventArgs e )
        {
            if( _resizerEnable && ( ( (Panel) sender ).Name == "_borderAngle" || ( (Panel) sender ).Name == "_borderRight" ) )
                Width = ( MousePosition.X - Left ) < _menuConteiner.Width ? _menuConteiner.Width : ( MousePosition.X - Left );

            if( _resizerEnable && ( ( (Panel) sender ).Name == "_borderAngle" || ( (Panel) sender ).Name == "_borderDown" ) )
                Height = ( MousePosition.Y - Top ) < _tobBarContainer.Height ? _tobBarContainer.Height : MousePosition.Y - Top;
        }
    }
}
