namespace WindowsFormsApplication1 {
  partial class AddNewStudents {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.txtFirstName = new System.Windows.Forms.TextBox();
      this.txtLastName = new System.Windows.Forms.TextBox();
      this.txtClass = new System.Windows.Forms.TextBox();
      this.txtAge = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.chkList = new System.Windows.Forms.CheckedListBox();
      this.picImage = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
      this.SuspendLayout();
      // 
      // txtFirstName
      // 
      this.txtFirstName.Location = new System.Drawing.Point(317, 38);
      this.txtFirstName.Name = "txtFirstName";
      this.txtFirstName.Size = new System.Drawing.Size(393, 20);
      this.txtFirstName.TabIndex = 0;
      // 
      // txtLastName
      // 
      this.txtLastName.Location = new System.Drawing.Point(317, 92);
      this.txtLastName.Name = "txtLastName";
      this.txtLastName.Size = new System.Drawing.Size(393, 20);
      this.txtLastName.TabIndex = 1;
      // 
      // txtClass
      // 
      this.txtClass.Location = new System.Drawing.Point(317, 138);
      this.txtClass.Name = "txtClass";
      this.txtClass.Size = new System.Drawing.Size(393, 20);
      this.txtClass.TabIndex = 2;
      // 
      // txtAge
      // 
      this.txtAge.Location = new System.Drawing.Point(317, 182);
      this.txtAge.Name = "txtAge";
      this.txtAge.Size = new System.Drawing.Size(393, 20);
      this.txtAge.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "First Name ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Last Name ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(37, 138);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Class ";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(37, 182);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Age ";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(37, 227);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(51, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Subjects ";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(317, 416);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 11;
      this.button1.Text = "Aceptar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // chkList
      // 
      this.chkList.FormattingEnabled = true;
      this.chkList.Location = new System.Drawing.Point(317, 227);
      this.chkList.Name = "chkList";
      this.chkList.Size = new System.Drawing.Size(393, 139);
      this.chkList.TabIndex = 13;
      // 
      // picImage
      // 
      this.picImage.Location = new System.Drawing.Point(40, 275);
      this.picImage.Name = "picImage";
      this.picImage.Size = new System.Drawing.Size(185, 91);
      this.picImage.TabIndex = 14;
      this.picImage.TabStop = false;
      // 
      // AddNewStudents
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(762, 451);
      this.Controls.Add(this.picImage);
      this.Controls.Add(this.chkList);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtAge);
      this.Controls.Add(this.txtClass);
      this.Controls.Add(this.txtLastName);
      this.Controls.Add(this.txtFirstName);
      this.Name = "AddNewStudents";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.TextBox txtClass;
    private System.Windows.Forms.TextBox txtAge;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckedListBox chkList;
    private System.Windows.Forms.PictureBox picImage;
  }
}

