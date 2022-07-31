
namespace Led7segcountdown_winform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Led_State = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.button_Dis = new System.Windows.Forms.Button();
            this.comboBox_Comport = new System.Windows.Forms.ComboBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.led7Segment1 = new ThanhDangNguyen.LibLED7Segment.Led7Segment();
            this.led7Segment2 = new ThanhDangNguyen.LibLED7Segment.Led7Segment();
            this.label_Hexcode = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Giá trị bắt đầu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // Led_State
            // 
            this.Led_State.BackColor = System.Drawing.Color.Transparent;
            this.Led_State.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.Led_State.Location = new System.Drawing.Point(19, 49);
            this.Led_State.Name = "Led_State";
            this.Led_State.Size = new System.Drawing.Size(34, 33);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_status);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox_Baudrate);
            this.groupBox2.Controls.Add(this.button_Dis);
            this.groupBox2.Controls.Add(this.comboBox_Comport);
            this.groupBox2.Controls.Add(this.button_Connect);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 138);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết nối/ COM";
            // 
            // textBox_status
            // 
            this.textBox_status.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_status.ForeColor = System.Drawing.Color.White;
            this.textBox_status.Location = new System.Drawing.Point(33, 74);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.Size = new System.Drawing.Size(121, 25);
            this.textBox_status.TabIndex = 14;
            this.textBox_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "COM Port";
            // 
            // comboBox_Baudrate
            // 
            this.comboBox_Baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Baudrate.FormattingEnabled = true;
            this.comboBox_Baudrate.Location = new System.Drawing.Point(62, 48);
            this.comboBox_Baudrate.Name = "comboBox_Baudrate";
            this.comboBox_Baudrate.Size = new System.Drawing.Size(114, 21);
            this.comboBox_Baudrate.TabIndex = 11;
            // 
            // button_Dis
            // 
            this.button_Dis.Location = new System.Drawing.Point(103, 109);
            this.button_Dis.Name = "button_Dis";
            this.button_Dis.Size = new System.Drawing.Size(73, 23);
            this.button_Dis.TabIndex = 10;
            this.button_Dis.Text = "Disconnect";
            this.button_Dis.UseVisualStyleBackColor = true;
            this.button_Dis.Click += new System.EventHandler(this.button_Dis_Click);
            // 
            // comboBox_Comport
            // 
            this.comboBox_Comport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Comport.FormattingEnabled = true;
            this.comboBox_Comport.Location = new System.Drawing.Point(62, 21);
            this.comboBox_Comport.Name = "comboBox_Comport";
            this.comboBox_Comport.Size = new System.Drawing.Size(114, 21);
            this.comboBox_Comport.TabIndex = 9;
            this.comboBox_Comport.SelectedIndexChanged += new System.EventHandler(this.comboBox_Comport_SelectedIndexChanged);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(8, 109);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 7;
            this.button_Connect.Text = "Connnect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Data_receive);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(402, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Designed by BMD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(128, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "COUNTDOWN DEVICE - BLUETOOTH";
            // 
            // led7Segment1
            // 
            this.led7Segment1.BackColor = System.Drawing.Color.Gainsboro;
            this.led7Segment1.LEDDpVisible = false;
            this.led7Segment1.LEDHexCode = ((byte)(192));
            this.led7Segment1.LEDOffColor = System.Drawing.Color.Gainsboro;
            this.led7Segment1.LEDOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.led7Segment1.Location = new System.Drawing.Point(36, 48);
            this.led7Segment1.Name = "led7Segment1";
            this.led7Segment1.Size = new System.Drawing.Size(77, 100);
            this.led7Segment1.TabIndex = 0;
            this.led7Segment1.Type = ThanhDangNguyen.LibLED7Segment.Led7Segment.LedType.COM_ANODE;
           // this.led7Segment1.SegmentLightChanged += new System.EventHandler(this.led7Segment1_SegmentLightChanged);
            // 
            // led7Segment2
            // 
            this.led7Segment2.BackColor = System.Drawing.Color.Gainsboro;
            this.led7Segment2.LEDDpVisible = false;
            this.led7Segment2.LEDHexCode = ((byte)(192));
            this.led7Segment2.LEDOffColor = System.Drawing.Color.Gainsboro;
            this.led7Segment2.LEDOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.led7Segment2.Location = new System.Drawing.Point(113, 48);
            this.led7Segment2.Name = "led7Segment2";
            this.led7Segment2.Size = new System.Drawing.Size(75, 100);
            this.led7Segment2.TabIndex = 1;
            this.led7Segment2.Type = ThanhDangNguyen.LibLED7Segment.Led7Segment.LedType.COM_ANODE;
            // 
            // label_Hexcode
            // 
            this.label_Hexcode.AutoSize = true;
            this.label_Hexcode.Location = new System.Drawing.Point(7, 34);
            this.label_Hexcode.Name = "label_Hexcode";
            this.label_Hexcode.Size = new System.Drawing.Size(56, 13);
            this.label_Hexcode.TabIndex = 6;
            this.label_Hexcode.Text = "Data send";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label_Hexcode);
            this.groupBox3.Location = new System.Drawing.Point(301, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 118);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Send/ Receive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Receive";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.shapeContainer1);
            this.groupBox4.Location = new System.Drawing.Point(215, 163);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(80, 118);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Led Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "State";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Led_State});
            this.shapeContainer1.Size = new System.Drawing.Size(74, 99);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(215, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "buimanhdat2000@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 310);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.led7Segment1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.led7Segment2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Counter - Led 7SEG ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Baudrate;
        private System.Windows.Forms.Button button_Dis;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox comboBox_Comport;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ThanhDangNguyen.LibLED7Segment.Led7Segment led7Segment1;
        private ThanhDangNguyen.LibLED7Segment.Led7Segment led7Segment2;
        private System.Windows.Forms.Label label_Hexcode;
        private System.Windows.Forms.GroupBox groupBox3;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Led_State;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label8;
    }
}

