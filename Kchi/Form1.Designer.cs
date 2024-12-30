namespace Kchi
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
            this.components = new System.ComponentModel.Container();
            this.cuiFormDrag1 = new CuoreUI.cuiFormDrag(this.components);
            this.cuiFormRounder1 = new CuoreUI.Components.cuiFormRounder();
            this.cuiFormAnimator1 = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.shrinkButton2 = new Kchi.ShrinkButton();
            this.shrinkButton1 = new Kchi.ShrinkButton();
            this.shrinkButton3 = new Kchi.ShrinkButton();
            this.shrinkButton4 = new Kchi.ShrinkButton();
            this.shrinkButton5 = new Kchi.ShrinkButton();
            this.SuspendLayout();
            // 
            // cuiFormDrag1
            // 
            this.cuiFormDrag1.TargetForm = this;
            // 
            // cuiFormRounder1
            // 
            this.cuiFormRounder1.EnhanceCorners = false;
            this.cuiFormRounder1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder1.Rounding = 8;
            this.cuiFormRounder1.TargetForm = this;
            // 
            // cuiFormAnimator1
            // 
            this.cuiFormAnimator1.Duration = 400;
            this.cuiFormAnimator1.EasingType = CuoreUI.Drawing.EasingTypes.QuartOut;
            this.cuiFormAnimator1.TargetForm = this;
            // 
            // shrinkButton2
            // 
            this.shrinkButton2.AnimationDuration = 1000;
            this.shrinkButton2.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.shrinkButton2.Location = new System.Drawing.Point(159, 77);
            this.shrinkButton2.Name = "shrinkButton2";
            this.shrinkButton2.Size = new System.Drawing.Size(78, 66);
            this.shrinkButton2.TabIndex = 1;
            this.shrinkButton2.TargetSize = 0.75F;
            // 
            // shrinkButton1
            // 
            this.shrinkButton1.AnimationDuration = 250;
            this.shrinkButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shrinkButton1.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.shrinkButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.shrinkButton1.Location = new System.Drawing.Point(108, 244);
            this.shrinkButton1.Name = "shrinkButton1";
            this.shrinkButton1.Size = new System.Drawing.Size(186, 55);
            this.shrinkButton1.TabIndex = 0;
            this.shrinkButton1.TargetSize = 0.75F;
            // 
            // shrinkButton3
            // 
            this.shrinkButton3.AnimationDuration = 1000;
            this.shrinkButton3.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.shrinkButton3.Location = new System.Drawing.Point(361, 192);
            this.shrinkButton3.Name = "shrinkButton3";
            this.shrinkButton3.Size = new System.Drawing.Size(78, 184);
            this.shrinkButton3.TabIndex = 2;
            this.shrinkButton3.TargetSize = 0.75F;
            // 
            // shrinkButton4
            // 
            this.shrinkButton4.AnimationDuration = 2500;
            this.shrinkButton4.EasingType = CuoreUI.Drawing.EasingTypes.QuintIn;
            this.shrinkButton4.Location = new System.Drawing.Point(458, 37);
            this.shrinkButton4.Name = "shrinkButton4";
            this.shrinkButton4.Size = new System.Drawing.Size(280, 360);
            this.shrinkButton4.TabIndex = 3;
            this.shrinkButton4.TargetSize = 0.75F;
            // 
            // shrinkButton5
            // 
            this.shrinkButton5.AnimationDuration = 2000;
            this.shrinkButton5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shrinkButton5.EasingType = CuoreUI.Drawing.EasingTypes.ExpoIn;
            this.shrinkButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.shrinkButton5.Location = new System.Drawing.Point(277, 37);
            this.shrinkButton5.Name = "shrinkButton5";
            this.shrinkButton5.Size = new System.Drawing.Size(162, 149);
            this.shrinkButton5.TabIndex = 4;
            this.shrinkButton5.TargetSize = 0.75F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(6)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shrinkButton5);
            this.Controls.Add(this.shrinkButton4);
            this.Controls.Add(this.shrinkButton3);
            this.Controls.Add(this.shrinkButton2);
            this.Controls.Add(this.shrinkButton1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.cuiFormDrag cuiFormDrag1;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator1;
        private ShrinkButton shrinkButton1;
        private ShrinkButton shrinkButton2;
        private ShrinkButton shrinkButton4;
        private ShrinkButton shrinkButton3;
        private ShrinkButton shrinkButton5;
    }
}

