namespace Tik_TUT
{
    partial class UCBeginner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBeginner));
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cirticularButton11 = new Tik_TUT.CirticularButton1();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(264, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "TAKE A SHORTCUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(269, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Basic Concepts";
            // 
            // cirticularButton11
            // 
            this.cirticularButton11.BackColor = System.Drawing.Color.Lime;
            this.cirticularButton11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirticularButton11.BackgroundImage")));
            this.cirticularButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cirticularButton11.FlatAppearance.BorderSize = 0;
            this.cirticularButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cirticularButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.cirticularButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cirticularButton11.Location = new System.Drawing.Point(318, 145);
            this.cirticularButton11.Name = "cirticularButton11";
            this.cirticularButton11.Size = new System.Drawing.Size(130, 130);
            this.cirticularButton11.TabIndex = 13;
            this.cirticularButton11.UseVisualStyleBackColor = false;
            this.cirticularButton11.Click += new System.EventHandler(this.cirticularButton11_Click);
            // 
            // UCBeginner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cirticularButton11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "UCBeginner";
            this.Size = new System.Drawing.Size(780, 547);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private CirticularButton1 cirticularButton11;
    }
}
