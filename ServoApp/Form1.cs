using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServoApp
{
    public partial class Form1 : Form
    {
        private SerialPort myPort = null;
        private string[] baudRateList = { "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "128000", "256000" };

        // data structure
        const int CMD = 0;
        const int SC = 1;
        const int POS_H = 1;
        const int POS_L = 2;
        // commnad header
        const int POSITION_CMD = 0b10000000;
        const int READ_CMD = 0b10100000;
        const int WRITE_CMD = 0b11000000;
        const int ID_CMD = 0b11100000;
        // sub command
        const int EEPROM_SC = 0x00;
        const int STRC_SC = 0x01;
        const int SPD_SC = 0x02;
        const int CUR_SC = 0x03;
        const int TMP_SC = 0x04;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // call constructor
            myPort = new SerialPort();

            // get enable port list
            string[] port_list = SerialPort.GetPortNames();
            // set enable port to GUI
            portCB.Items.Clear();
            portCB.Items.AddRange(port_list);
            // preset portCB item to first item
            if (port_list.Length > 0)
                portCB.SelectedIndex = 0;

            // set enable baudrate to GUI
            baudRateCB.Items.Clear();
            baudRateCB.Items.AddRange(baudRateList);
            // preset baudrateCB item to first item
            if (baudRateList.Length > 0)
                baudRateCB.SelectedIndex = 0;

            idCB.Items.Clear();
            for(int id = 0; id < 256; id++)
            {
                idCB.Items.Add(id);
            }
            idCB.SelectedIndex = 0;

            // set maximum & minimum value
            positionTB.Minimum = -90;
            positionTB.Maximum = 90;
            // set first value
            positionTB.Value = 0;
            // set minimum unit
            positionTB.SmallChange = 1;
            // set scale interval
            positionTB.TickFrequency = 10;

            // set maximum & minimum value
            positionValue.Minimum = -90;
            positionValue.Maximum = 90;
            // set first value
            positionValue.Value = 0;
            // set increment value
            positionValue.Increment = 1;
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            // set parameter for serial communication
            string port_name = (string)portCB.SelectedItem;
            int baud_rate = int.Parse((string)baudRateCB.SelectedItem);
            Parity parity = Parity.Even;
            int data_bits = 8;
            StopBits stop_bits = StopBits.One;
            myPort = new SerialPort(port_name, baud_rate, parity, data_bits, stop_bits);

            // open com port
            myPort.Open();
        }

        private void positionTB_Scroll(object sender, EventArgs e)
        {
            if(myPort == null)
            {
                MessageBox.Show("Open COM Port !!");
            }
            else
            {
                int position = positionTB.Value;
                positionValue.Value = position;
                setMotorPosition(0, position);
            }
        }

        private void positionValue_ValueChanged(object sender, EventArgs e)
        {
            if (myPort == null)
            {
                MessageBox.Show("Open COM Port !!");
            }
            else
            {
                int position = (int)positionValue.Value;
                positionTB.Value = position;
                setMotorPosition(0, position);
            }
        }

        private void setMotorPosition(int id, int pos)
        {
            byte[] tx;
            tx = new byte[3];

            // convert position to command
            tx[CMD] = (byte)(POSITION_CMD | id);
            if (pos < -135)
            {
                pos = 135;
            }
            else if (pos > 135)
            {
                pos = 135;
            }
            pos = (11500 - 3500) / 270 * pos + 7500;
            tx[POS_H] = (byte)((pos >> 7) & 0x7F);
            tx[POS_L] = (byte)(pos & 0x7F);

            // set position to motor
            myPort.Write(tx, 0, tx.Length);
        }
    }
}
