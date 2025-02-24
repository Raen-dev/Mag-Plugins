namespace Mag_SuitBuilder.Spells
{
	partial class CantripSelectorControl
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			defaultsComboBox = new System.Windows.Forms.ComboBox();
			cmdClear = new System.Windows.Forms.Button();
			dataGridView1 = new System.Windows.Forms.DataGridView();
			ColAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColProtections = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColMagics = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColPrimaries = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColSecondaries = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColDefenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
			ColTinkCraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
			lblLegendary = new System.Windows.Forms.Label();
			lblMinor = new System.Windows.Forms.Label();
			lblMajor = new System.Windows.Forms.Label();
			lblEpic = new System.Windows.Forms.Label();
			lblLoadDefaults = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// defaultsComboBox
			// 
			defaultsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			defaultsComboBox.FormattingEnabled = true;
			defaultsComboBox.Items.AddRange(new object[] { "", "Finesse", "Generic", "Heavy", "Light", "Missile", "Tinker", "Two Hand", "Void", "War" });
			defaultsComboBox.Location = new System.Drawing.Point(91, 3);
			defaultsComboBox.Name = "defaultsComboBox";
			defaultsComboBox.Size = new System.Drawing.Size(154, 23);
			defaultsComboBox.TabIndex = 1;
			defaultsComboBox.SelectedIndexChanged += defaultsComboBox_SelectedIndexChanged;
			// 
			// cmdClear
			// 
			cmdClear.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			cmdClear.Location = new System.Drawing.Point(518, 3);
			cmdClear.Name = "cmdClear";
			cmdClear.Size = new System.Drawing.Size(64, 23);
			cmdClear.TabIndex = 2;
			cmdClear.Text = "Clear";
			cmdClear.UseVisualStyleBackColor = true;
			cmdClear.Click += cmdClear_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			dataGridView1.ColumnHeadersVisible = false;
			dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColAttributes, ColProtections, ColMagics, ColPrimaries, ColSecondaries, ColDefenses, ColTinkCraft });
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridView1.Location = new System.Drawing.Point(0, 33);
			dataGridView1.Margin = new System.Windows.Forms.Padding(0);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.RowTemplate.Height = 20;
			dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			dataGridView1.Size = new System.Drawing.Size(585, 143);
			dataGridView1.TabIndex = 3;
			dataGridView1.CellClick += dataGridView1_CellClick;
			dataGridView1.CellDoubleClick += dataGridView1_CellClick;
			// 
			// ColAttributes
			// 
			ColAttributes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColAttributes.HeaderText = "ColAttributes";
			ColAttributes.Name = "ColAttributes";
			ColAttributes.ReadOnly = true;
			ColAttributes.Width = 5;
			// 
			// ColProtections
			// 
			ColProtections.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColProtections.HeaderText = "ColProtections";
			ColProtections.Name = "ColProtections";
			ColProtections.ReadOnly = true;
			ColProtections.Width = 5;
			// 
			// ColMagics
			// 
			ColMagics.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColMagics.HeaderText = "ColMagics";
			ColMagics.Name = "ColMagics";
			ColMagics.ReadOnly = true;
			ColMagics.Width = 5;
			// 
			// ColPrimaries
			// 
			ColPrimaries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColPrimaries.HeaderText = "ColPrimaries";
			ColPrimaries.Name = "ColPrimaries";
			ColPrimaries.ReadOnly = true;
			ColPrimaries.Width = 5;
			// 
			// ColSecondaries
			// 
			ColSecondaries.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColSecondaries.HeaderText = "ColSecondaries";
			ColSecondaries.Name = "ColSecondaries";
			ColSecondaries.ReadOnly = true;
			ColSecondaries.Width = 5;
			// 
			// ColDefenses
			// 
			ColDefenses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColDefenses.HeaderText = "ColDefenses";
			ColDefenses.Name = "ColDefenses";
			ColDefenses.ReadOnly = true;
			ColDefenses.Width = 5;
			// 
			// ColTinkCraft
			// 
			ColTinkCraft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			ColTinkCraft.HeaderText = "ColTinkCraft";
			ColTinkCraft.Name = "ColTinkCraft";
			ColTinkCraft.ReadOnly = true;
			ColTinkCraft.Width = 5;
			// 
			// lblLegendary
			// 
			lblLegendary.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblLegendary.AutoSize = true;
			lblLegendary.BackColor = System.Drawing.Color.DarkOrange;
			lblLegendary.Location = new System.Drawing.Point(3, 179);
			lblLegendary.Name = "lblLegendary";
			lblLegendary.Size = new System.Drawing.Size(60, 15);
			lblLegendary.TabIndex = 4;
			lblLegendary.Text = "- Lgndry -";
			// 
			// lblMinor
			// 
			lblMinor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblMinor.AutoSize = true;
			lblMinor.BackColor = System.Drawing.Color.LightBlue;
			lblMinor.Location = new System.Drawing.Point(200, 179);
			lblMinor.Name = "lblMinor";
			lblMinor.Size = new System.Drawing.Size(65, 15);
			lblMinor.TabIndex = 5;
			lblMinor.Text = "-- Minor --";
			// 
			// lblMajor
			// 
			lblMajor.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblMajor.AutoSize = true;
			lblMajor.BackColor = System.Drawing.Color.Pink;
			lblMajor.Location = new System.Drawing.Point(130, 179);
			lblMajor.Name = "lblMajor";
			lblMajor.Size = new System.Drawing.Size(64, 15);
			lblMajor.TabIndex = 6;
			lblMajor.Text = "-- Major --";
			// 
			// lblEpic
			// 
			lblEpic.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			lblEpic.AutoSize = true;
			lblEpic.BackColor = System.Drawing.Color.LightGreen;
			lblEpic.Location = new System.Drawing.Point(69, 179);
			lblEpic.Name = "lblEpic";
			lblEpic.Size = new System.Drawing.Size(55, 15);
			lblEpic.TabIndex = 7;
			lblEpic.Text = "-- Epic --";
			// 
			// lblLoadDefaults
			// 
			lblLoadDefaults.AutoSize = true;
			lblLoadDefaults.Location = new System.Drawing.Point(3, 7);
			lblLoadDefaults.Name = "lblLoadDefaults";
			lblLoadDefaults.Size = new System.Drawing.Size(82, 15);
			lblLoadDefaults.TabIndex = 8;
			lblLoadDefaults.Text = "Load Defaults:";
			// 
			// CantripSelectorControl
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			Controls.Add(lblLoadDefaults);
			Controls.Add(lblEpic);
			Controls.Add(lblMajor);
			Controls.Add(lblMinor);
			Controls.Add(lblLegendary);
			Controls.Add(dataGridView1);
			Controls.Add(cmdClear);
			Controls.Add(defaultsComboBox);
			Name = "CantripSelectorControl";
			Size = new System.Drawing.Size(585, 197);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private System.Windows.Forms.ComboBox defaultsComboBox;
		private System.Windows.Forms.Button cmdClear;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColAttributes;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColProtections;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColMagics;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColPrimaries;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColSecondaries;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColDefenses;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTinkCraft;
		private System.Windows.Forms.Label lblLegendary;
		private System.Windows.Forms.Label lblMinor;
		private System.Windows.Forms.Label lblMajor;
		private System.Windows.Forms.Label lblEpic;
		private System.Windows.Forms.Label lblLoadDefaults;
	}
}
