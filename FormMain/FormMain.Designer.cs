using FormMain;

namespace FormMain
{
    partial class FormMain
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
            this.custom_Sidebar1 = new Custom_Sidebar();
            this.SuspendLayout();
            // 
            // custom_Sidebar1
            // 
            this.custom_Sidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.custom_Sidebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.custom_Sidebar1.Location = new System.Drawing.Point(0, 0);
            this.custom_Sidebar1.Name = "custom_Sidebar1";
            this.custom_Sidebar1.SelectedIndex = -1;
            this.custom_Sidebar1.Size = new System.Drawing.Size(300, 517);
            this.custom_Sidebar1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 517);
            this.Controls.Add(this.custom_Sidebar1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG QUẢN LÝ THƯ VIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Sidebar custom_Sidebar1;
    }
}

