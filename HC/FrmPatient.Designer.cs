
namespace HC
{
    partial class FrmPatient
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
            this.TbcPatient = new System.Windows.Forms.TabControl();
            this.TbpPersonalData = new System.Windows.Forms.TabPage();
            this.TbpAdress = new System.Windows.Forms.TabPage();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtFileNumber = new System.Windows.Forms.TextBox();
            this.LblFileNumber = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblCreationDate = new System.Windows.Forms.Label();
            this.MntCreationDate = new System.Windows.Forms.MonthCalendar();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.CmbOcupation = new System.Windows.Forms.ComboBox();
            this.CmbEthnic = new System.Windows.Forms.ComboBox();
            this.CmbCivilStatus = new System.Windows.Forms.ComboBox();
            this.LblGender = new System.Windows.Forms.Label();
            this.LblOcupation = new System.Windows.Forms.Label();
            this.LblEthic = new System.Windows.Forms.Label();
            this.LblCivilStatus = new System.Windows.Forms.Label();
            this.LblSchooling = new System.Windows.Forms.Label();
            this.CmbSchooling = new System.Windows.Forms.ComboBox();
            this.TxtExteriorNumber = new System.Windows.Forms.TextBox();
            this.LblExteriorNumber = new System.Windows.Forms.Label();
            this.TxtStreet = new System.Windows.Forms.TextBox();
            this.LblStreet = new System.Windows.Forms.Label();
            this.TxtIdAdress = new System.Windows.Forms.TextBox();
            this.LblIdAdress = new System.Windows.Forms.Label();
            this.TxtColony = new System.Windows.Forms.TextBox();
            this.LblColony = new System.Windows.Forms.Label();
            this.TxtInteriorNumber = new System.Windows.Forms.TextBox();
            this.LblInteriorNumber = new System.Windows.Forms.Label();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.LblPhone = new System.Windows.Forms.Label();
            this.TbcPatient.SuspendLayout();
            this.TbpPersonalData.SuspendLayout();
            this.TbpAdress.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbcPatient
            // 
            this.TbcPatient.Controls.Add(this.TbpPersonalData);
            this.TbcPatient.Controls.Add(this.TbpAdress);
            this.TbcPatient.Location = new System.Drawing.Point(12, 12);
            this.TbcPatient.Name = "TbcPatient";
            this.TbcPatient.SelectedIndex = 0;
            this.TbcPatient.Size = new System.Drawing.Size(776, 426);
            this.TbcPatient.TabIndex = 0;
            // 
            // TbpPersonalData
            // 
            this.TbpPersonalData.Controls.Add(this.TxtPhone);
            this.TbpPersonalData.Controls.Add(this.LblPhone);
            this.TbpPersonalData.Controls.Add(this.LblSchooling);
            this.TbpPersonalData.Controls.Add(this.CmbSchooling);
            this.TbpPersonalData.Controls.Add(this.LblCivilStatus);
            this.TbpPersonalData.Controls.Add(this.LblEthic);
            this.TbpPersonalData.Controls.Add(this.LblOcupation);
            this.TbpPersonalData.Controls.Add(this.LblGender);
            this.TbpPersonalData.Controls.Add(this.CmbCivilStatus);
            this.TbpPersonalData.Controls.Add(this.CmbEthnic);
            this.TbpPersonalData.Controls.Add(this.CmbOcupation);
            this.TbpPersonalData.Controls.Add(this.CmbGender);
            this.TbpPersonalData.Controls.Add(this.MntCreationDate);
            this.TbpPersonalData.Controls.Add(this.LblCreationDate);
            this.TbpPersonalData.Controls.Add(this.TxtName);
            this.TbpPersonalData.Controls.Add(this.LblName);
            this.TbpPersonalData.Controls.Add(this.TxtFileNumber);
            this.TbpPersonalData.Controls.Add(this.LblFileNumber);
            this.TbpPersonalData.Controls.Add(this.TxtId);
            this.TbpPersonalData.Controls.Add(this.LblId);
            this.TbpPersonalData.Location = new System.Drawing.Point(4, 25);
            this.TbpPersonalData.Name = "TbpPersonalData";
            this.TbpPersonalData.Padding = new System.Windows.Forms.Padding(3);
            this.TbpPersonalData.Size = new System.Drawing.Size(768, 397);
            this.TbpPersonalData.TabIndex = 0;
            this.TbpPersonalData.Text = "Datos Personales";
            this.TbpPersonalData.UseVisualStyleBackColor = true;
            // 
            // TbpAdress
            // 
            this.TbpAdress.Controls.Add(this.TxtColony);
            this.TbpAdress.Controls.Add(this.LblColony);
            this.TbpAdress.Controls.Add(this.TxtInteriorNumber);
            this.TbpAdress.Controls.Add(this.LblInteriorNumber);
            this.TbpAdress.Controls.Add(this.TxtExteriorNumber);
            this.TbpAdress.Controls.Add(this.LblExteriorNumber);
            this.TbpAdress.Controls.Add(this.TxtStreet);
            this.TbpAdress.Controls.Add(this.LblStreet);
            this.TbpAdress.Controls.Add(this.TxtIdAdress);
            this.TbpAdress.Controls.Add(this.LblIdAdress);
            this.TbpAdress.Location = new System.Drawing.Point(4, 25);
            this.TbpAdress.Name = "TbpAdress";
            this.TbpAdress.Padding = new System.Windows.Forms.Padding(3);
            this.TbpAdress.Size = new System.Drawing.Size(768, 397);
            this.TbpAdress.TabIndex = 1;
            this.TbpAdress.Text = "Domicilio";
            this.TbpAdress.UseVisualStyleBackColor = true;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(43, 20);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(23, 17);
            this.LblId.TabIndex = 0;
            this.LblId.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(109, 15);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 22);
            this.TxtId.TabIndex = 1;
            // 
            // TxtFileNumber
            // 
            this.TxtFileNumber.Location = new System.Drawing.Point(109, 56);
            this.TxtFileNumber.Name = "TxtFileNumber";
            this.TxtFileNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtFileNumber.TabIndex = 3;
            // 
            // LblFileNumber
            // 
            this.LblFileNumber.AutoSize = true;
            this.LblFileNumber.Location = new System.Drawing.Point(13, 59);
            this.LblFileNumber.Name = "LblFileNumber";
            this.LblFileNumber.Size = new System.Drawing.Size(82, 17);
            this.LblFileNumber.TabIndex = 2;
            this.LblFileNumber.Text = "Expediente:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(109, 97);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 5;
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(23, 100);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(62, 17);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Nombre:";
            // 
            // LblCreationDate
            // 
            this.LblCreationDate.AutoSize = true;
            this.LblCreationDate.Location = new System.Drawing.Point(463, 20);
            this.LblCreationDate.Name = "LblCreationDate";
            this.LblCreationDate.Size = new System.Drawing.Size(127, 17);
            this.LblCreationDate.TabIndex = 6;
            this.LblCreationDate.Text = "Fecha de Creación";
            // 
            // MntCreationDate
            // 
            this.MntCreationDate.Location = new System.Drawing.Point(466, 46);
            this.MntCreationDate.Name = "MntCreationDate";
            this.MntCreationDate.TabIndex = 7;
            // 
            // CmbGender
            // 
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Location = new System.Drawing.Point(111, 179);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(121, 24);
            this.CmbGender.TabIndex = 8;
            // 
            // CmbOcupation
            // 
            this.CmbOcupation.FormattingEnabled = true;
            this.CmbOcupation.Location = new System.Drawing.Point(111, 222);
            this.CmbOcupation.Name = "CmbOcupation";
            this.CmbOcupation.Size = new System.Drawing.Size(121, 24);
            this.CmbOcupation.TabIndex = 9;
            // 
            // CmbEthnic
            // 
            this.CmbEthnic.FormattingEnabled = true;
            this.CmbEthnic.Location = new System.Drawing.Point(111, 265);
            this.CmbEthnic.Name = "CmbEthnic";
            this.CmbEthnic.Size = new System.Drawing.Size(121, 24);
            this.CmbEthnic.TabIndex = 10;
            // 
            // CmbCivilStatus
            // 
            this.CmbCivilStatus.FormattingEnabled = true;
            this.CmbCivilStatus.Location = new System.Drawing.Point(111, 308);
            this.CmbCivilStatus.Name = "CmbCivilStatus";
            this.CmbCivilStatus.Size = new System.Drawing.Size(121, 24);
            this.CmbCivilStatus.TabIndex = 11;
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Location = new System.Drawing.Point(24, 182);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(60, 17);
            this.LblGender.TabIndex = 12;
            this.LblGender.Text = "Genero:";
            // 
            // LblOcupation
            // 
            this.LblOcupation.AutoSize = true;
            this.LblOcupation.Location = new System.Drawing.Point(14, 225);
            this.LblOcupation.Name = "LblOcupation";
            this.LblOcupation.Size = new System.Drawing.Size(80, 17);
            this.LblOcupation.TabIndex = 13;
            this.LblOcupation.Text = "Ocupación:";
            // 
            // LblEthic
            // 
            this.LblEthic.AutoSize = true;
            this.LblEthic.Location = new System.Drawing.Point(34, 268);
            this.LblEthic.Name = "LblEthic";
            this.LblEthic.Size = new System.Drawing.Size(40, 17);
            this.LblEthic.TabIndex = 14;
            this.LblEthic.Text = "Etnia";
            // 
            // LblCivilStatus
            // 
            this.LblCivilStatus.AutoSize = true;
            this.LblCivilStatus.Location = new System.Drawing.Point(10, 311);
            this.LblCivilStatus.Name = "LblCivilStatus";
            this.LblCivilStatus.Size = new System.Drawing.Size(89, 17);
            this.LblCivilStatus.TabIndex = 15;
            this.LblCivilStatus.Text = "Estado Civil: ";
            // 
            // LblSchooling
            // 
            this.LblSchooling.AutoSize = true;
            this.LblSchooling.Location = new System.Drawing.Point(9, 354);
            this.LblSchooling.Name = "LblSchooling";
            this.LblSchooling.Size = new System.Drawing.Size(90, 17);
            this.LblSchooling.TabIndex = 17;
            this.LblSchooling.Text = "Escolaridad: ";
            // 
            // CmbSchooling
            // 
            this.CmbSchooling.FormattingEnabled = true;
            this.CmbSchooling.Location = new System.Drawing.Point(111, 351);
            this.CmbSchooling.Name = "CmbSchooling";
            this.CmbSchooling.Size = new System.Drawing.Size(121, 24);
            this.CmbSchooling.TabIndex = 16;
            // 
            // TxtExteriorNumber
            // 
            this.TxtExteriorNumber.Location = new System.Drawing.Point(170, 112);
            this.TxtExteriorNumber.Name = "TxtExteriorNumber";
            this.TxtExteriorNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtExteriorNumber.TabIndex = 11;
            // 
            // LblExteriorNumber
            // 
            this.LblExteriorNumber.AutoSize = true;
            this.LblExteriorNumber.Location = new System.Drawing.Point(43, 117);
            this.LblExteriorNumber.Name = "LblExteriorNumber";
            this.LblExteriorNumber.Size = new System.Drawing.Size(118, 17);
            this.LblExteriorNumber.TabIndex = 10;
            this.LblExteriorNumber.Text = "Número Exterior: ";
            // 
            // TxtStreet
            // 
            this.TxtStreet.Location = new System.Drawing.Point(170, 67);
            this.TxtStreet.Name = "TxtStreet";
            this.TxtStreet.Size = new System.Drawing.Size(100, 22);
            this.TxtStreet.TabIndex = 9;
            // 
            // LblStreet
            // 
            this.LblStreet.AutoSize = true;
            this.LblStreet.Location = new System.Drawing.Point(43, 72);
            this.LblStreet.Name = "LblStreet";
            this.LblStreet.Size = new System.Drawing.Size(47, 17);
            this.LblStreet.TabIndex = 8;
            this.LblStreet.Text = "Calle: ";
            // 
            // TxtIdAdress
            // 
            this.TxtIdAdress.Location = new System.Drawing.Point(170, 25);
            this.TxtIdAdress.Name = "TxtIdAdress";
            this.TxtIdAdress.Size = new System.Drawing.Size(100, 22);
            this.TxtIdAdress.TabIndex = 7;
            // 
            // LblIdAdress
            // 
            this.LblIdAdress.AutoSize = true;
            this.LblIdAdress.Location = new System.Drawing.Point(43, 30);
            this.LblIdAdress.Name = "LblIdAdress";
            this.LblIdAdress.Size = new System.Drawing.Size(23, 17);
            this.LblIdAdress.TabIndex = 6;
            this.LblIdAdress.Text = "Id:";
            // 
            // TxtColony
            // 
            this.TxtColony.Location = new System.Drawing.Point(170, 202);
            this.TxtColony.Name = "TxtColony";
            this.TxtColony.Size = new System.Drawing.Size(100, 22);
            this.TxtColony.TabIndex = 15;
            // 
            // LblColony
            // 
            this.LblColony.AutoSize = true;
            this.LblColony.Location = new System.Drawing.Point(43, 207);
            this.LblColony.Name = "LblColony";
            this.LblColony.Size = new System.Drawing.Size(63, 17);
            this.LblColony.TabIndex = 14;
            this.LblColony.Text = "Colonia: ";
            // 
            // TxtInteriorNumber
            // 
            this.TxtInteriorNumber.Location = new System.Drawing.Point(170, 160);
            this.TxtInteriorNumber.Name = "TxtInteriorNumber";
            this.TxtInteriorNumber.Size = new System.Drawing.Size(100, 22);
            this.TxtInteriorNumber.TabIndex = 13;
            // 
            // LblInteriorNumber
            // 
            this.LblInteriorNumber.AutoSize = true;
            this.LblInteriorNumber.Location = new System.Drawing.Point(43, 165);
            this.LblInteriorNumber.Name = "LblInteriorNumber";
            this.LblInteriorNumber.Size = new System.Drawing.Size(114, 17);
            this.LblInteriorNumber.TabIndex = 12;
            this.LblInteriorNumber.Text = "Número Interior: ";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(111, 138);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(100, 22);
            this.TxtPhone.TabIndex = 19;
            // 
            // LblPhone
            // 
            this.LblPhone.AutoSize = true;
            this.LblPhone.Location = new System.Drawing.Point(18, 141);
            this.LblPhone.Name = "LblPhone";
            this.LblPhone.Size = new System.Drawing.Size(72, 17);
            this.LblPhone.TabIndex = 18;
            this.LblPhone.Text = "Teléfono: ";
            // 
            // FrmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbcPatient);
            this.Name = "FrmPatient";
            this.Text = "FrmPatient";
            this.TbcPatient.ResumeLayout(false);
            this.TbpPersonalData.ResumeLayout(false);
            this.TbpPersonalData.PerformLayout();
            this.TbpAdress.ResumeLayout(false);
            this.TbpAdress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbcPatient;
        private System.Windows.Forms.TabPage TbpPersonalData;
        private System.Windows.Forms.TabPage TbpAdress;
        private System.Windows.Forms.MonthCalendar MntCreationDate;
        private System.Windows.Forms.Label LblCreationDate;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtFileNumber;
        private System.Windows.Forms.Label LblFileNumber;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblSchooling;
        private System.Windows.Forms.ComboBox CmbSchooling;
        private System.Windows.Forms.Label LblCivilStatus;
        private System.Windows.Forms.Label LblEthic;
        private System.Windows.Forms.Label LblOcupation;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.ComboBox CmbCivilStatus;
        private System.Windows.Forms.ComboBox CmbEthnic;
        private System.Windows.Forms.ComboBox CmbOcupation;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.TextBox TxtExteriorNumber;
        private System.Windows.Forms.Label LblExteriorNumber;
        private System.Windows.Forms.TextBox TxtStreet;
        private System.Windows.Forms.Label LblStreet;
        private System.Windows.Forms.TextBox TxtIdAdress;
        private System.Windows.Forms.Label LblIdAdress;
        private System.Windows.Forms.TextBox TxtColony;
        private System.Windows.Forms.Label LblColony;
        private System.Windows.Forms.TextBox TxtInteriorNumber;
        private System.Windows.Forms.Label LblInteriorNumber;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.Label LblPhone;
    }
}