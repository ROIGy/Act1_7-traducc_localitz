namespace Prova_Avaluacio
{
    partial class PlayerNameDialog
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
            txtName = new TextBox();
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 58);
            label1.Name = "label1";
            label1.Size = new Size(289, 20);
            label1.TabIndex = 1;
            label1.Text = "Introdueix el teu nom per iniciar la partida";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(106, 163);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 2;
            btnOk.Text = "D'acord";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(243, 163);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel·lar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // PlayerNameDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(label1);
            Controls.Add(txtName);
            Name = "PlayerNameDialog";
            Text = "PlayerNameDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Button btnOk;
        private Button btnCancel;
    }
}