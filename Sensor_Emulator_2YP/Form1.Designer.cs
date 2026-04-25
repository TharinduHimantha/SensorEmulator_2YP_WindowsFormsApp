namespace Sensor_Emulator_2YP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnConnect = new Button();
            lblStatus = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnPublish = new Button();
            txtSensorHealth = new TextBox();
            label4 = new Label();
            txtValue = new TextBox();
            label3 = new Label();
            txtDeviceId = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtLogs = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(51, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 104);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Connection";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.LightGreen;
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.DarkGreen;
            btnConnect.Location = new Point(534, 39);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(197, 37);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "Establish Connection";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F);
            lblStatus.ForeColor = Color.OrangeRed;
            lblStatus.Location = new Point(305, 45);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(119, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Disconnected";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(28, 45);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 0;
            label1.Text = "Current Status with MQTT Broker:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPublish);
            groupBox2.Controls.Add(txtSensorHealth);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtValue);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtDeviceId);
            groupBox2.Controls.Add(label2);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(51, 161);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(790, 240);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "PayLoad";
            // 
            // btnPublish
            // 
            btnPublish.BackColor = Color.LightBlue;
            btnPublish.FlatAppearance.BorderSize = 0;
            btnPublish.FlatStyle = FlatStyle.Flat;
            btnPublish.Font = new Font("Nirmala UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPublish.ForeColor = Color.FromArgb(21, 101, 192);
            btnPublish.Location = new Point(606, 163);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(113, 37);
            btnPublish.TabIndex = 3;
            btnPublish.Text = "Send Data";
            btnPublish.UseVisualStyleBackColor = false;
            btnPublish.Click += btnPublish_Click;
            // 
            // txtSensorHealth
            // 
            txtSensorHealth.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSensorHealth.Location = new Point(327, 169);
            txtSensorHealth.Name = "txtSensorHealth";
            txtSensorHealth.Size = new Size(170, 31);
            txtSensorHealth.TabIndex = 6;
            txtSensorHealth.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(47, 172);
            label4.Name = "label4";
            label4.Size = new Size(213, 28);
            label4.TabIndex = 5;
            label4.Text = "Sensor Health / Battery";
            // 
            // txtValue
            // 
            txtValue.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValue.Location = new Point(327, 105);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(170, 31);
            txtValue.TabIndex = 4;
            txtValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 105);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 3;
            label3.Text = "Sensor Reading";
            // 
            // txtDeviceId
            // 
            txtDeviceId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDeviceId.Location = new Point(327, 43);
            txtDeviceId.Name = "txtDeviceId";
            txtDeviceId.Size = new Size(170, 31);
            txtDeviceId.TabIndex = 2;
            txtDeviceId.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 46);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 1;
            label2.Text = "Device ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtLogs);
            groupBox3.ForeColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(51, 431);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(790, 177);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Logs";
            // 
            // txtLogs
            // 
            txtLogs.BackColor = Color.Black;
            txtLogs.BorderStyle = BorderStyle.None;
            txtLogs.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogs.ForeColor = Color.Lime;
            txtLogs.Location = new Point(16, 29);
            txtLogs.Multiline = true;
            txtLogs.Name = "txtLogs";
            txtLogs.ReadOnly = true;
            txtLogs.ScrollBars = ScrollBars.Vertical;
            txtLogs.Size = new Size(748, 134);
            txtLogs.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(900, 647);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            Text = "Sensor Emulator - KernelX";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblStatus;
        private Label label1;
        private Button btnConnect;
        private TextBox txtSensorHealth;
        private Label label4;
        private TextBox txtValue;
        private Label label3;
        private TextBox txtDeviceId;
        private Label label2;
        private Button btnPublish;
        private TextBox txtLogs;
    }
}
