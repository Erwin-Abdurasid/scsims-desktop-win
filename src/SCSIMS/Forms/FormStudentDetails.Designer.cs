﻿namespace SCSIMS.Forms;

partial class FormStudentDetails
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
        SuspendLayout();
        // 
        // FormStudentDetails
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Turquoise;
        ClientSize = new Size(1337, 716);
        ControlBox = false;
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(3, 2, 3, 2);
        MaximizeBox = false;
        Name = "FormStudentDetails";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
    }

    #endregion
}