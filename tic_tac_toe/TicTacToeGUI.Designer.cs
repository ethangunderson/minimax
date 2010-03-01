namespace tic_tac_toe
{
  partial class TicTacToeGUI
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.SuspendLayout();

      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 12);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 62);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += delegate { this.button_click(new Space(0, 0), new System.EventArgs()); };

      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(93, 12);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 62);
      this.button2.TabIndex = 1;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += delegate { this.button_click(new Space(0, 1), new System.EventArgs()); };

      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(174, 12);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 62);
      this.button3.TabIndex = 2;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += delegate { this.button_click(new Space(0, 2), new System.EventArgs()); };

      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(12, 80);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(75, 62);
      this.button4.TabIndex = 3;
      this.button4.Text = "button4";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += delegate { this.button_click(new Space(1, 0), new System.EventArgs()); };

      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(93, 80);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 62);
      this.button5.TabIndex = 4;
      this.button5.Text = "button5";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += delegate { this.button_click(new Space(1, 1), new System.EventArgs()); };

      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(174, 80);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 62);
      this.button6.TabIndex = 5;
      this.button6.Text = "button6";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += delegate { this.button_click(new Space(1, 2), new System.EventArgs()); };

      // 
      // button7
      // 
      this.button7.Location = new System.Drawing.Point(12, 148);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(75, 62);
      this.button7.TabIndex = 6;
      this.button7.Text = "button7";
      this.button7.UseVisualStyleBackColor = true;
      this.button7.Click += delegate { this.button_click(new Space(2, 0), new System.EventArgs()); };

      // 
      // button8
      // 
      this.button8.Location = new System.Drawing.Point(93, 148);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(75, 62);
      this.button8.TabIndex = 7;
      this.button8.Text = "button8";
      this.button8.UseVisualStyleBackColor = true;
      this.button8.Click += delegate { this.button_click(new Space(2, 1), new System.EventArgs()); };

      // 
      // button9
      // 
      this.button9.Location = new System.Drawing.Point(174, 148);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(75, 62);
      this.button9.TabIndex = 8;
      this.button9.Text = "button9";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += delegate { this.button_click(new Space(2, 2), new System.EventArgs()); };

      // 
      // Form1
      // 
      this.Font = new System.Drawing.Font("Arial", 15f);
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(261, 225);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Tic Tac Toe";
      this.MaximizeBox = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
  }
}

