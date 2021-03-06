﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Puzzle_Matcher.WinForms
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.ImageIn = new System.Windows.Forms.PictureBox();
			this.ProcessImage = new System.Windows.Forms.PictureBox();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.OrginalImg = new System.Windows.Forms.PictureBox();
			this.X_axis = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Y_axis = new System.Windows.Forms.NumericUpDown();
			this.prog = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.Preview = new System.Windows.Forms.PictureBox();
			this.MatchDistance = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.ImageIn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProcessImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrginalImg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.X_axis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Y_axis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prog)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MatchDistance)).BeginInit();
			this.SuspendLayout();
			// 
			// ImageIn
			// 
			this.ImageIn.Image = global::Puzzle_Matcher.Properties.Resources.ButtonLoadImage;
			this.ImageIn.InitialImage = null;
			this.ImageIn.Location = new System.Drawing.Point(13, 12);
			this.ImageIn.Name = "ImageIn";
			this.ImageIn.Size = new System.Drawing.Size(376, 400);
			this.ImageIn.TabIndex = 0;
			this.ImageIn.TabStop = false;
			this.ImageIn.Click += new System.EventHandler(this.ImageIn_Click);
			// 
			// ProcessImage
			// 
			this.ProcessImage.Enabled = false;
			this.ProcessImage.Image = global::Puzzle_Matcher.Properties.Resources.ButtonProcessImage;
			this.ProcessImage.InitialImage = null;
			this.ProcessImage.Location = new System.Drawing.Point(12, 469);
			this.ProcessImage.Name = "ProcessImage";
			this.ProcessImage.Size = new System.Drawing.Size(760, 100);
			this.ProcessImage.TabIndex = 1;
			this.ProcessImage.TabStop = false;
			this.ProcessImage.Click += new System.EventHandler(this.ProcessImage_Click);
			// 
			// ofd
			// 
			this.ofd.DefaultExt = "jpg";
			this.ofd.Filter = "JPG Image (.jpg) |*.jpg|PNG Image (.png)|*.png|GIF Image (.gif)|*.gif|BITMAP Imag" +
    "e (.bmp)|*.bmp|All files (.*)|*.*";
			this.ofd.InitialDirectory = "%HOMEPATH%";
			this.ofd.Title = "Wybierz zdjęcie";
			// 
			// OrginalImg
			// 
			this.OrginalImg.Image = global::Puzzle_Matcher.Properties.Resources.ButtonLoadImageOrg;
			this.OrginalImg.InitialImage = null;
			this.OrginalImg.Location = new System.Drawing.Point(396, 12);
			this.OrginalImg.Name = "OrginalImg";
			this.OrginalImg.Size = new System.Drawing.Size(376, 400);
			this.OrginalImg.TabIndex = 2;
			this.OrginalImg.TabStop = false;
			this.OrginalImg.Click += new System.EventHandler(this.OrginalImg_Click);
			// 
			// X_axis
			// 
			this.X_axis.Location = new System.Drawing.Point(135, 417);
			this.X_axis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.X_axis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.X_axis.Name = "X_axis";
			this.X_axis.Size = new System.Drawing.Size(46, 20);
			this.X_axis.TabIndex = 3;
			this.X_axis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 419);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ilość puzzli w poziomie:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 445);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Ilość puzzli w pionie:";
			// 
			// Y_axis
			// 
			this.Y_axis.Location = new System.Drawing.Point(135, 443);
			this.Y_axis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.Y_axis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.Y_axis.Name = "Y_axis";
			this.Y_axis.Size = new System.Drawing.Size(46, 20);
			this.Y_axis.TabIndex = 5;
			this.Y_axis.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// prog
			// 
			this.prog.Location = new System.Drawing.Point(575, 417);
			this.prog.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.prog.Name = "prog";
			this.prog.Size = new System.Drawing.Size(68, 20);
			this.prog.TabIndex = 7;
			this.prog.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(395, 420);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Wielkość konturów (domyślnie: 300):";
			// 
			// Preview
			// 
			this.Preview.Image = global::Puzzle_Matcher.Properties.Resources.ButtonPreviewImage;
			this.Preview.InitialImage = global::Puzzle_Matcher.Properties.Resources.ButtonPreviewImage;
			this.Preview.Location = new System.Drawing.Point(650, 416);
			this.Preview.Name = "Preview";
			this.Preview.Size = new System.Drawing.Size(122, 21);
			this.Preview.TabIndex = 9;
			this.Preview.TabStop = false;
			this.Preview.Click += new System.EventHandler(this.Preview_Click);
			// 
			// MatchDistance
			// 
			this.MatchDistance.DecimalPlaces = 1;
			this.MatchDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MatchDistance.Location = new System.Drawing.Point(575, 443);
			this.MatchDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.MatchDistance.Name = "MatchDistance";
			this.MatchDistance.Size = new System.Drawing.Size(68, 20);
			this.MatchDistance.TabIndex = 10;
			this.MatchDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(395, 445);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(174, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Minimalny dystans  (domyślnie: 0.1):";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 582);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.MatchDistance);
			this.Controls.Add(this.Preview);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.prog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Y_axis);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.X_axis);
			this.Controls.Add(this.OrginalImg);
			this.Controls.Add(this.ProcessImage);
			this.Controls.Add(this.ImageIn);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Okno główne";
			((System.ComponentModel.ISupportInitialize)(this.ImageIn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProcessImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrginalImg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.X_axis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Y_axis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prog)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MatchDistance)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox ImageIn;
		private PictureBox ProcessImage;
		private OpenFileDialog ofd;
		private PictureBox OrginalImg;
		private NumericUpDown X_axis;
		private Label label1;
		private Label label2;
		private NumericUpDown Y_axis;
		private NumericUpDown prog;
		private Label label3;
		private PictureBox Preview;
		private NumericUpDown MatchDistance;
		private Label label4;
	}
}

