namespace Circl_Calc
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Arialabel = new System.Windows.Forms.Label();
            this.СirculFerencelabel = new System.Windows.Forms.Label();
            this.Diameterlabel = new System.Windows.Forms.Label();
            this.Radiuslabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Radius",
            "Diameter",
            "Сircul ference",
            "Aria"});
            this.comboBox1.Location = new System.Drawing.Point(6, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "You know: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Arialabel);
            this.groupBox3.Controls.Add(this.СirculFerencelabel);
            this.groupBox3.Controls.Add(this.Diameterlabel);
            this.groupBox3.Controls.Add(this.Radiuslabel);
            this.groupBox3.Controls.Add(this.CalculateButton);
            this.groupBox3.Location = new System.Drawing.Point(139, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 120);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // Arialabel
            // 
            this.Arialabel.AutoSize = true;
            this.Arialabel.Location = new System.Drawing.Point(62, 52);
            this.Arialabel.Name = "Arialabel";
            this.Arialabel.Size = new System.Drawing.Size(39, 15);
            this.Arialabel.TabIndex = 7;
            this.Arialabel.Text = "Aria: ?";
            // 
            // СirculFerencelabel
            // 
            this.СirculFerencelabel.AutoSize = true;
            this.СirculFerencelabel.Location = new System.Drawing.Point(32, 70);
            this.СirculFerencelabel.Name = "СirculFerencelabel";
            this.СirculFerencelabel.Size = new System.Drawing.Size(91, 15);
            this.СirculFerencelabel.TabIndex = 6;
            this.СirculFerencelabel.Text = "Сircul ference: ?";
            // 
            // Diameterlabel
            // 
            this.Diameterlabel.AutoSize = true;
            this.Diameterlabel.Location = new System.Drawing.Point(48, 37);
            this.Diameterlabel.Name = "Diameterlabel";
            this.Diameterlabel.Size = new System.Drawing.Size(66, 15);
            this.Diameterlabel.TabIndex = 5;
            this.Diameterlabel.Text = "Diameter: ?";
            // 
            // Radiuslabel
            // 
            this.Radiuslabel.AutoSize = true;
            this.Radiuslabel.Location = new System.Drawing.Point(58, 22);
            this.Radiuslabel.Name = "Radiuslabel";
            this.Radiuslabel.Size = new System.Drawing.Size(47, 15);
            this.Radiuslabel.TabIndex = 4;
            this.Radiuslabel.Text = "Radius?";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(44, 86);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 29);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imput";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "It is:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Insret valve";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 162);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Circl calc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button CalculateButton;
        private Label label2;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private Label Arialabel;
        private Label СirculFerencelabel;
        private Label Diameterlabel;
        private Label Radiuslabel;
    }
}