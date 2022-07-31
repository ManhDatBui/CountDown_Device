using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Drawing;

namespace Led7segcountdown_winform
{
    public partial class Form1 : Form
    {
        byte a;
        byte hc, dv;
        byte b;
        string TransmitData = string.Empty;
        string ReceiveData = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
           
            foreach(string port in ports)
            {
                comboBox_Comport.Items.Add(port);
            }

        }

        private void comboBox_Comport_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox_Comport.Text;

        }


        private void button_Connect_Click(object sender, EventArgs e)
        {
            if(comboBox_Comport.Text == "")
            {
                MessageBox.Show(" Vui lòng chọn cổng COM", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if(serialPort1.IsOpen)
                    {
                        MessageBox.Show(" Cổng COM đã được kết nối ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        serialPort1.Open();
                        comboBox_Comport.Enabled = false;
                        textBox_status.BackColor = Color.Blue;
                        textBox_status.Text = "Connecting...";
                        
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show(" Cổng COM đã được sử dụng . Vui lòng chọn COM khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
           
            //serialPort1.Open();
        }

        private void button_Dis_Click(object sender, EventArgs e)
        {
            try // 
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    comboBox_Comport.Enabled = true;
                    textBox_status.BackColor = Color.Red;
                    textBox_status.Text = "Disconnected";
                    button1.Enabled = true;

                }
                else
                {
                    MessageBox.Show(" Cổng COM đã ngắt kết nối", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Cổng COM đã được sử dụng. Vui lòng chọn COM khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Data_receive(object sender, SerialDataReceivedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;// trong khi đếm thì không được gửi để tránh lỗi
            button1.Enabled = false;
            ReceiveData = serialPort1.ReadTo("&");
            textBox3.Text = ReceiveData.ToString(); 
            b = byte.Parse(textBox3.Text);
            hc = (byte)(b / 10);
            dv = (byte)(b % 10);

            if (b == 0)
                        {
                
                            led7Segment1.LEDNumber = hc;  
                            led7Segment2.LEDNumber = dv;
                // 
                            Led_State.BackColor = Color.Red;
                            Thread.Sleep(3000);
                            Led_State.BackColor = Color.LightYellow;
                            button1.Enabled = true;

            }
              led7Segment1.LEDNumber = hc;
              led7Segment2.LEDNumber = dv;
           
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try // 
            {
                if (serialPort1.IsOpen)
                {   
                    
                    a = byte.Parse(textBox1.Text);
                    if (a <= 99 && a >= 9)
                    {
                        TransmitData = "@" + a.ToString() + "&";
                        serialPort1.Write(TransmitData);
                        textBox2.Text = TransmitData;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số trong khoảng 9 - 99", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                }
                else
                {
                    MessageBox.Show(" Cổng COM chưa được kết nối. Vui lòng kiểm tra lại", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" Cổng COM đã được sử dụng. Vui lòng chọn COM khác", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



          
        }

        
    }
}
