using System;
using ShuttleNET;
using System.Windows.Forms;

namespace WraperTestApp
{
    public partial class Form1 : Form
    {

        private Contour _shuttle;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //Instance the class...
            _shuttle = new Contour();

            //Add event handlers...
            _shuttle.ButtonClick += _shuttle_ButtonClick;
            _shuttle.JogMove += _shuttle_JogMove;
            _shuttle.ShuttleMove += _shuttle_ShuttleMove;

            //Set default control values...
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;

            //Set default textbox values...
            textBox1.Text = "-";
            textBox2.Text = "-";
            textBox3.Text = "-";
        }

        private void _shuttle_ShuttleMove(object sender, ShuttleEventArgs e)
        {
            //Convert ShuttleEventArgs data into text...
            textBox1.Text = Convert.ToString(e.Device);
            textBox2.Text = Convert.ToString(e.DeviceNumber);
            textBox3.Text = Convert.ToString("SHUTTLE MOVE - Direction: " + e.Direction + " - Zone: " + e.Zone);
        }

        private void _shuttle_JogMove(object sender, JogEventArgs e)
        {
            //Convert JogEventArgs data into text...
            textBox1.Text = Convert.ToString(e.Device);
            textBox2.Text = Convert.ToString(e.DeviceNumber);
            textBox3.Text = Convert.ToString("JOG MOVED - Direction: " + e.Direction);
        }


        private void _shuttle_ButtonClick(object sender, ButtonClickEventArgs e)
        {
            //Convert ButtonClickEventArgs data into text...
            textBox1.Text = Convert.ToString(e.Device);
            textBox2.Text = Convert.ToString(e.DeviceNumber);
            textBox3.Text = Convert.ToString("BUTTON CLICKED - Button Number: " + e.ButtonNumber);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //****Register callback locally (only recieves events when THIS APP has focus)****
            
            DeviceType _deviceType = (DeviceType)(comboBox1.SelectedIndex + 1);
            DeviceNo _deviceNo = DeviceNo.SHUTTLEPRIMARY;

            if (radioButton1.Checked)
            {
                _deviceNo = DeviceNo.SHUTTLEPRIMARY;
            }
            else
            {
                _deviceNo = DeviceNo.SHUTTLEPRIMARY;
            }

            //Try to register the selected device...
            ErrorCode result =  (ErrorCode)_shuttle.RegisterCallBack(_deviceType, _deviceNo);

            //USE THIS: _shuttle.RegisterCallbackGlobal(_deviceType, _deviceNo); to register for global events...l

            //Report the error status code to user...
            MessageBox.Show(Convert.ToString("Register device result code is: " + result));
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Exit
            base.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Unregister devices...
            DeviceType _deviceType = (DeviceType)(comboBox1.SelectedIndex + 1);
            DeviceNo _deviceNo = DeviceNo.SHUTTLEPRIMARY;

            if (radioButton1.Checked)
            {
                _deviceNo = DeviceNo.SHUTTLEPRIMARY;
            }
            else
            {
                _deviceNo = DeviceNo.SHUTTLEPRIMARY;
            }

            //Try to unregister the selected device...
            ErrorCode result = (ErrorCode)_shuttle.UnregisterCallBack(_deviceType, _deviceNo);

            //Reset status texts...
            textBox1.Text = "-";
            textBox2.Text = "-";
            textBox3.Text = "-";

            //Report the error (status) code to user...
            MessageBox.Show(Convert.ToString("Unregister device result code is: " + result));
        }
    }
}
