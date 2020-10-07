using SlimDX.DirectInput;
using System;
using System.Windows.Forms;

namespace XOutput
{
    public partial class XOut : Form
    {

        public XOut()
        {
            InitializeComponent();
            this.controllerOptions.Click += (sender, e) => OpenOptions();
            /*for (int i = 1; i <= 4; i++)
            {
                controllerIndex.addOption(i.ToString());
            }
            controllerIndex.SelectedIndex = 0;*/
        }

        private void XOut_Load(object sender, EventArgs e)
        {
            controllerManager = new ControllerManager(this);
        }

        private void XOut_Shown(object sender, EventArgs e)
        {
            UpdateInfo(controllerManager.DetectControllers());
        }

        private void XOut_Closing(object sender, FormClosingEventArgs e)
        {
            if (controllerManager.IsActive)
            {
                controllerManager.Stop();
            }
            ControllerDevice device = controllerManager.getController();
            device.joystick.Unacquire();
            device.joystick.Dispose();
            device.keyboard.Dispose();
            controllerManager.directInput.Dispose();
        }

        private void StartStopBtn_Click(object sender, EventArgs e)
        {
            if (StartStopBtn.Text == "Start")
            {
                if (optionsWindow != null)
                {
                    System.Media.SystemSounds.Asterisk.Play();
                    optionsWindow.Focus();
                    return;
                }
                if (controllerManager.Start())
                {
                    StartStopBtn.Text = "Stop";
                    controllerOptions.Enabled = false;
                    //controllerIndex.Enabled = false;
                }
            }
            else
            {
                if (controllerManager.Stop())
                {
                    StartStopBtn.Text = "Start";
                    controllerOptions.Enabled = true;
                    //controllerIndex.Enabled = true;
                }
            }
        }

        private void UpdateInfo(ControllerDevice dev)
        {
            if (dev != null)
            {
                controllerBox.Visible = true;
                controllerBox.Text = dev.name;
            }
            else
            {
                controllerBox.Visible = false;
            }
        }

        private void OpenOptions()
        {
            if (optionsWindow == null)
            {
                optionsWindow = new ControllerOptions(controllerManager.getController());
                optionsWindow.Show();
                optionsWindow.Activate();
                optionsWindow.FormClosed += (sender, e) => { optionsWindow = null; };
            }
            else
            {
                System.Media.SystemSounds.Asterisk.Play();
                optionsWindow.Focus();
            }
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                if (m.Msg == 0x0219)
                {
                    lock (this)
                    {
                        UpdateInfo(controllerManager.DetectControllers());
                    }
                }
            }
            catch { }

            base.WndProc(ref m);
        }
    }
}
