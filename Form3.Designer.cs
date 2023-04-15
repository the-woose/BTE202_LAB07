namespace BTE202_LAB07
{
    partial class Form3
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
            txtInfo = new TextBox();
            cmdGetlnfo = new Button();
            txtName = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // txtInfo
            // 
            txtInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInfo.Enabled = false;
            txtInfo.Location = new Point(12, 61);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(712, 141);
            txtInfo.TabIndex = 4;
            // 
            // cmdGetlnfo
            // 
            cmdGetlnfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmdGetlnfo.Location = new Point(649, 23);
            cmdGetlnfo.Name = "cmdGetlnfo";
            cmdGetlnfo.Size = new Size(75, 23);
            cmdGetlnfo.TabIndex = 5;
            cmdGetlnfo.Text = "Bilgiyi Getir";
            cmdGetlnfo.UseVisualStyleBackColor = true;
            cmdGetlnfo.Click += cmdGetlnfo_Click;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Location = new Point(348, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(295, 23);
            txtName.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(330, 15);
            lblName.TabIndex = 7;
            lblName.Text = "Adınızı yazın (İsim-ler ve Soyisim aralarında boşluk bırakarak):";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 238);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(cmdGetlnfo);
            Controls.Add(txtInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            Text = "Yavuz Sava - 2210780022";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInfo;
        private Button cmdGetlnfo;
        private TextBox txtName;
        private Label lblName;
    }
}