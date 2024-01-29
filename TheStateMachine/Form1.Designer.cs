
namespace TheStateMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_plugIn = new System.Windows.Forms.Button();
            this.btn_switchOn = new System.Windows.Forms.Button();
            this.btn_switchOff = new System.Windows.Forms.Button();
            this.btn_unplug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_myState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_plugIn
            // 
            this.btn_plugIn.Location = new System.Drawing.Point(73, 560);
            this.btn_plugIn.Name = "btn_plugIn";
            this.btn_plugIn.Size = new System.Drawing.Size(152, 59);
            this.btn_plugIn.TabIndex = 0;
            this.btn_plugIn.Text = "Plug In";
            this.btn_plugIn.UseVisualStyleBackColor = true;
            this.btn_plugIn.Click += new System.EventHandler(this.btn_plugIn_Click);
            // 
            // btn_switchOn
            // 
            this.btn_switchOn.Location = new System.Drawing.Point(231, 560);
            this.btn_switchOn.Name = "btn_switchOn";
            this.btn_switchOn.Size = new System.Drawing.Size(152, 59);
            this.btn_switchOn.TabIndex = 1;
            this.btn_switchOn.Text = "Switch On";
            this.btn_switchOn.UseVisualStyleBackColor = true;
            this.btn_switchOn.Click += new System.EventHandler(this.btn_switchOn_Click);
            // 
            // btn_switchOff
            // 
            this.btn_switchOff.Location = new System.Drawing.Point(389, 560);
            this.btn_switchOff.Name = "btn_switchOff";
            this.btn_switchOff.Size = new System.Drawing.Size(152, 59);
            this.btn_switchOff.TabIndex = 2;
            this.btn_switchOff.Text = "Switch Off";
            this.btn_switchOff.UseVisualStyleBackColor = true;
            this.btn_switchOff.Click += new System.EventHandler(this.btn_switchOff_Click);
            // 
            // btn_unplug
            // 
            this.btn_unplug.Location = new System.Drawing.Point(547, 560);
            this.btn_unplug.Name = "btn_unplug";
            this.btn_unplug.Size = new System.Drawing.Size(152, 59);
            this.btn_unplug.TabIndex = 3;
            this.btn_unplug.Text = "Unplug";
            this.btn_unplug.UseVisualStyleBackColor = true;
            this.btn_unplug.Click += new System.EventHandler(this.btn_unplug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "State = ";
            // 
            // lbl_myState
            // 
            this.lbl_myState.AutoSize = true;
            this.lbl_myState.Location = new System.Drawing.Point(343, 61);
            this.lbl_myState.Name = "lbl_myState";
            this.lbl_myState.Size = new System.Drawing.Size(25, 20);
            this.lbl_myState.TabIndex = 5;
            this.lbl_myState.Text = "....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 652);
            this.Controls.Add(this.lbl_myState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_unplug);
            this.Controls.Add(this.btn_switchOff);
            this.Controls.Add(this.btn_switchOn);
            this.Controls.Add(this.btn_plugIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The State Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_plugIn;
        private System.Windows.Forms.Button btn_switchOn;
        private System.Windows.Forms.Button btn_switchOff;
        private System.Windows.Forms.Button btn_unplug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_myState;
    }
}

