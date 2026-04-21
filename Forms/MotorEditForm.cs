using ProductionLineControl.Enums;
using ProductionLineControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionLineControl.Forms
{
    public partial class MotorEditForm : Form
    {
        public Motor Motor { get; private set; }

        public MotorEditForm(Motor motor = null)
        {
            InitializeComponent();

            cbManufacturer.DataSource = Enum.GetValues(typeof(Manufacturer));
            cbConnectionType.DataSource = Enum.GetValues(typeof(ConnectionType));
            cbProtocol.DataSource = Enum.GetValues(typeof(ProtocolType));

            Motor = motor ?? new Motor();

            txtName.PlaceholderText = "Motor name";
            txtIp.PlaceholderText = "192.168.0.10";
            txtPort.PlaceholderText = "502";
            txtComPort.PlaceholderText = "COM3";
            txtBaudRate.PlaceholderText = "9600";

            BindData();
            UpdateConnectionFields();
        }

        private void BindData()
        {
            txtName.Text = Motor.Name;

            cbManufacturer.SelectedItem = Motor.Manufacturer;

            UpdateModels();

            cbModel.SelectedItem = Motor.Model;

            cbConnectionType.SelectedItem = Motor.ConnectionType;
            cbProtocol.SelectedItem = Motor.ProtocolType;

            txtIp.Text = Motor.Settings.IpAddress;
            txtPort.Text = Motor.Settings.Port.ToString();

            txtComPort.Text = Motor.Settings.ComPort;
            txtBaudRate.Text = Motor.Settings.BaudRate.ToString();
            numTargetSpeed.Value = (decimal)Motor.TargetSpeed;
        }

        private void UpdateConnectionFields()
        {
            bool isEthernet = (ConnectionType)cbConnectionType.SelectedItem == ConnectionType.Ethernet;

            txtIp.Enabled = isEthernet;
            txtPort.Enabled = isEthernet;

            txtComPort.Enabled = !isEthernet;
            txtBaudRate.Enabled = !isEthernet;
        }

        private void cbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateConnectionFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Motor.Name = txtName.Text;
            Motor.Model = cbModel.SelectedItem?.ToString();
            Motor.Manufacturer = (Manufacturer)cbManufacturer.SelectedItem;
            Motor.ConnectionType = (ConnectionType)cbConnectionType.SelectedItem;
            Motor.ProtocolType = (ProtocolType)cbProtocol.SelectedItem;
            Motor.TargetSpeed = (double)numTargetSpeed.Value;

            Motor.Settings.IpAddress = txtIp.Text;
            Motor.Settings.Port = int.TryParse(txtPort.Text, out var port) ? port : 0;

            Motor.Settings.ComPort = txtComPort.Text;
            Motor.Settings.BaudRate = int.TryParse(txtBaudRate.Text, out var baud) ? baud : 0;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateModels()
        {
            if (Motor == null) return;

            var manufacturer = (Manufacturer)cbManufacturer.SelectedItem;

            cbModel.DataSource = ModelCatalog.Models[manufacturer];

            if (!string.IsNullOrEmpty(Motor.Model))
                cbModel.SelectedItem = Motor.Model;
        }

        private void cbManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateModels();
        }
    }
}
