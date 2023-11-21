namespace while_döngüsü_ödev2_847
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
            this.lbSayilar1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbSayilar1
            // 
            this.lbSayilar1.FormattingEnabled = true;
            this.lbSayilar1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lbSayilar1.Location = new System.Drawing.Point(57, 56);
            this.lbSayilar1.Name = "lbSayilar1";
            this.lbSayilar1.Size = new System.Drawing.Size(125, 212);
            this.lbSayilar1.TabIndex = 0;
            this.lbSayilar1.SelectedIndexChanged += new System.EventHandler(this.lbSayilar1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSayilar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar1;
    }
}

