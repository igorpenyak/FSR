﻿namespace FSR.DesktopUI.Forms
{
    partial class ReserveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReserveForm));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnApplyReserve = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grbReserve = new System.Windows.Forms.GroupBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblSeat = new System.Windows.Forms.Label();
            this.txtFlightId = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.grbReserve.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(93, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // btnApplyReserve
            // 
            this.btnApplyReserve.Location = new System.Drawing.Point(59, 150);
            this.btnApplyReserve.Name = "btnApplyReserve";
            this.btnApplyReserve.Size = new System.Drawing.Size(80, 23);
            this.btnApplyReserve.TabIndex = 2;
            this.btnApplyReserve.Text = "Підтвердити";
            this.btnApplyReserve.UseVisualStyleBackColor = true;
            this.btnApplyReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(145, 150);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Ім\'я";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 48);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 5;
            this.lblSurname.Text = "Прізвище";
            // 
            // grbReserve
            // 
            this.grbReserve.Controls.Add(this.txtSeat);
            this.grbReserve.Controls.Add(this.txtFlightId);
            this.grbReserve.Controls.Add(this.lblSeat);
            this.grbReserve.Controls.Add(this.lblFlight);
            this.grbReserve.Controls.Add(this.lblSurname);
            this.grbReserve.Controls.Add(this.lblName);
            this.grbReserve.Controls.Add(this.txtSurname);
            this.grbReserve.Controls.Add(this.txtName);
            this.grbReserve.Location = new System.Drawing.Point(12, 12);
            this.grbReserve.Name = "grbReserve";
            this.grbReserve.Size = new System.Drawing.Size(260, 132);
            this.grbReserve.TabIndex = 6;
            this.grbReserve.TabStop = false;
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(6, 74);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(61, 13);
            this.lblFlight.TabIndex = 6;
            this.lblFlight.Text = "ID польоту";
            // 
            // lblSeat
            // 
            this.lblSeat.AutoSize = true;
            this.lblSeat.Location = new System.Drawing.Point(6, 100);
            this.lblSeat.Name = "lblSeat";
            this.lblSeat.Size = new System.Drawing.Size(36, 13);
            this.lblSeat.TabIndex = 7;
            this.lblSeat.Text = "Місце";
            // 
            // txtFlightId
            // 
            this.txtFlightId.Location = new System.Drawing.Point(93, 71);
            this.txtFlightId.Name = "txtFlightId";
            this.txtFlightId.Size = new System.Drawing.Size(100, 20);
            this.txtFlightId.TabIndex = 8;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(93, 97);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(100, 20);
            this.txtSeat.TabIndex = 9;
            // 
            // ReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.Controls.Add(this.grbReserve);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApplyReserve);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ReserveForm";
            this.Text = "Резервування";
            this.grbReserve.ResumeLayout(false);
            this.grbReserve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnApplyReserve;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox grbReserve;
        private System.Windows.Forms.Label lblSeat;
        private System.Windows.Forms.Label lblFlight;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtSeat;
        public System.Windows.Forms.TextBox txtFlightId;
    }
}