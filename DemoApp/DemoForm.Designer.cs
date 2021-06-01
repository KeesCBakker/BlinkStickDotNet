
namespace DemoApp
{
    partial class BlinkStickDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlinkStickDemo));
            this.btnBlinkGreen = new System.Windows.Forms.Button();
            this.btnSetRed = new System.Windows.Forms.Button();
            this.btnTurnOff = new System.Windows.Forms.Button();
            this.btnSetWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlinkGreen
            // 
            resources.ApplyResources(this.btnBlinkGreen, "btnBlinkGreen");
            this.btnBlinkGreen.Name = "btnBlinkGreen";
            this.btnBlinkGreen.UseVisualStyleBackColor = true;
            this.btnBlinkGreen.Click += new System.EventHandler(this.btnBlinkGreen_Click);
            // 
            // btnSetRed
            // 
            resources.ApplyResources(this.btnSetRed, "btnSetRed");
            this.btnSetRed.Name = "btnSetRed";
            this.btnSetRed.UseVisualStyleBackColor = true;
            this.btnSetRed.Click += new System.EventHandler(this.btnSetRed_Click);
            // 
            // btnTurnOff
            // 
            resources.ApplyResources(this.btnTurnOff, "btnTurnOff");
            this.btnTurnOff.Name = "btnTurnOff";
            this.btnTurnOff.UseVisualStyleBackColor = true;
            this.btnTurnOff.Click += new System.EventHandler(this.btnTurnOff_Click);
            // 
            // btnSetWhite
            // 
            resources.ApplyResources(this.btnSetWhite, "btnSetWhite");
            this.btnSetWhite.Name = "btnSetWhite";
            this.btnSetWhite.UseVisualStyleBackColor = true;
            this.btnSetWhite.Click += new System.EventHandler(this.btnSetWhite_Click);
            // 
            // BlinkStickDemo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSetWhite);
            this.Controls.Add(this.btnTurnOff);
            this.Controls.Add(this.btnSetRed);
            this.Controls.Add(this.btnBlinkGreen);
            this.Name = "BlinkStickDemo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlinkGreen;
        private System.Windows.Forms.Button btnSetRed;
        private System.Windows.Forms.Button btnTurnOff;
        private System.Windows.Forms.Button btnSetWhite;
    }
}

