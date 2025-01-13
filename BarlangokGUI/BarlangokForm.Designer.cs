namespace BarlangokGUI
{
    partial class BarlangokForm
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
            lblUi01 = new Label();
            btnKeres = new Button();
            lblUi02 = new Label();
            lblUi03 = new Label();
            lblUi04 = new Label();
            tbxAzon = new TextBox();
            tbxMely = new TextBox();
            tbxHossz = new TextBox();
            lblNev = new Label();
            btnMent = new Button();
            SuspendLayout();
            // 
            // lblUi01
            // 
            lblUi01.AutoSize = true;
            lblUi01.Location = new Point(19, 29);
            lblUi01.Margin = new Padding(10, 20, 3, 20);
            lblUi01.Name = "lblUi01";
            lblUi01.Size = new Size(114, 30);
            lblUi01.TabIndex = 0;
            lblUi01.Text = "Azonosító:";
            // 
            // btnKeres
            // 
            btnKeres.Location = new Point(450, 29);
            btnKeres.Name = "btnKeres";
            btnKeres.Size = new Size(222, 58);
            btnKeres.TabIndex = 1;
            btnKeres.Text = "Barlang keresése";
            btnKeres.UseVisualStyleBackColor = true;
            // 
            // lblUi02
            // 
            lblUi02.AutoSize = true;
            lblUi02.Location = new Point(19, 153);
            lblUi02.Margin = new Padding(10, 20, 3, 20);
            lblUi02.Name = "lblUi02";
            lblUi02.Size = new Size(144, 30);
            lblUi02.TabIndex = 0;
            lblUi02.Text = "Barlang neve:";
            // 
            // lblUi03
            // 
            lblUi03.AutoSize = true;
            lblUi03.Location = new Point(19, 277);
            lblUi03.Margin = new Padding(10, 20, 3, 20);
            lblUi03.Name = "lblUi03";
            lblUi03.Size = new Size(120, 30);
            lblUi03.TabIndex = 0;
            lblUi03.Text = "Hosszúság:";
            // 
            // lblUi04
            // 
            lblUi04.AutoSize = true;
            lblUi04.Location = new Point(19, 401);
            lblUi04.Margin = new Padding(10, 20, 3, 20);
            lblUi04.Name = "lblUi04";
            lblUi04.Size = new Size(100, 30);
            lblUi04.TabIndex = 0;
            lblUi04.Text = "Mélység:";
            // 
            // tbxAzon
            // 
            tbxAzon.Location = new Point(180, 26);
            tbxAzon.Name = "tbxAzon";
            tbxAzon.Size = new Size(211, 36);
            tbxAzon.TabIndex = 0;
            // 
            // tbxMely
            // 
            tbxMely.Location = new Point(180, 398);
            tbxMely.Name = "tbxMely";
            tbxMely.Size = new Size(211, 36);
            tbxMely.TabIndex = 3;
            // 
            // tbxHossz
            // 
            tbxHossz.Location = new Point(180, 274);
            tbxHossz.Name = "tbxHossz";
            tbxHossz.Size = new Size(211, 36);
            tbxHossz.TabIndex = 2;
            // 
            // lblNev
            // 
            lblNev.AutoSize = true;
            lblNev.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNev.Location = new Point(180, 153);
            lblNev.Margin = new Padding(10, 20, 3, 20);
            lblNev.Name = "lblNev";
            lblNev.Size = new Size(104, 30);
            lblNev.TabIndex = 0;
            lblNev.Text = "#######";
            // 
            // btnMent
            // 
            btnMent.Enabled = false;
            btnMent.Location = new Point(450, 376);
            btnMent.Name = "btnMent";
            btnMent.Size = new Size(222, 58);
            btnMent.TabIndex = 4;
            btnMent.Text = "Adatok mentése";
            btnMent.UseVisualStyleBackColor = true;
            // 
            // BarlangokForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(btnMent);
            Controls.Add(btnKeres);
            Controls.Add(tbxHossz);
            Controls.Add(tbxMely);
            Controls.Add(tbxAzon);
            Controls.Add(lblUi04);
            Controls.Add(lblUi03);
            Controls.Add(lblNev);
            Controls.Add(lblUi02);
            Controls.Add(lblUi01);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BarlangokForm";
            Text = "Barlangok";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUi01;
        private Button btnKeres;
        private Label lblUi02;
        private Label lblUi03;
        private Label lblUi04;
        private TextBox tbxAzon;
        private TextBox tbxMely;
        private TextBox tbxHossz;
        private Label lblNev;
        private Button btnMent;
    }
}
